﻿using Reloaded.ModHelper;
using System.Net;
using System.Net.Http;

namespace NoMansSky.Api
{
    public unsafe class Player
    {
        /// <summary>
        /// The address of GcPlayerStateData.
        /// </summary>
        public long GcPlayerStateAddress => _gcPlayerStateAddress;
        private long _gcPlayerStateAddress;

        /// <summary>
        /// The player's current active ship.
        /// </summary>
        public Ship CurrentShip { get; set; } = new Ship();


        public SuitRefiner SuitRefiner { get; set; } = new SuitRefiner();

        /// <summary>
        /// [BROKEN] Called whenever the value of the Player's health changes.
        /// <br/>The parameter is the amount that the health changed.
        /// </summary>
        public IModEventHook<int> OnHealthChanged { get; set; }

        /// <summary>
        /// [BROKEN] Called whenever the value of the Player's shield changes.
        /// <br/>The parameter is the amount that the shield changed.
        /// </summary>
        public IModEventHook<float> OnShieldChanged { get; set; }

        private GcPlayerStateData* state;

        public Player()
        {
            
        }



        /// <summary>
        /// Set's the address of the PlayerStateData and populates it.
        /// <br/>This method is used by the API to prepare the game data.
        /// <br/>Calling this method will negatively affect the game and might break your mods.
        /// </summary>
        /// <param name="address"></param>
        public void SetGcPlayerStateData(long address)
        {
            _gcPlayerStateAddress = address;
            if (_gcPlayerStateAddress == 0)
                return;

            state = (GcPlayerStateData*) _gcPlayerStateAddress;
        }

        /// <summary>
        /// Returns the health of the player's shield.
        /// </summary>
        /// <returns></returns>
        public float GetShieldHealth() => state->shield;

        /// <summary>
        /// Returns the player's current health.
        /// </summary>
        /// <returns></returns>
        public int GetHealth() => state->health;

        /// <summary>
        /// Returns how many units the player currently has.
        /// </summary>
        /// <returns></returns>
        public long GetUnits() => state->units;

        /// <summary>
        /// Returns how many nanites the player currently has.
        /// </summary>
        /// <returns></returns>
        public int GetNanites() => state->nanites;

        /// <summary>
        /// Returns how much quicksilver the player currently has.
        /// </summary>
        /// <returns></returns>
        public int GetQuicksilver() => state->quicksilver;

        /// <summary>
        /// Raise the player's health by an amount.
        /// </summary>
        /// <param name="amount">Amount to raise health by.</param>
        public void RaiseHealth(int amount)
        {
            SetHealth(GetHealth() + amount);
        }

        /// <summary>
        /// Reduce the player's health by an amount.
        /// </summary>
        /// <param name="amount">Amount to raise health by.</param>
        public void ReduceHealth(int amount)
        {
            SetHealth(GetHealth() - amount);
        }

        /// <summary>
        /// Set the player's health.
        /// </summary>
        /// <param name="newHealth">Amount to set the player's health to.</param>
        public void SetHealth(int newHealth) // amount = 38
        {
            if (newHealth <= 0)
            {
                // don't let the player die if we haven't loaded in the game yet.
                newHealth = Game.Instance.IsInGame ? 0 : 1; 
            }

            int currentHealth = GetHealth();
            bool isLosingHealth = currentHealth > newHealth;

            int difference = isLosingHealth ? currentHealth - newHealth : newHealth - currentHealth;

            var amountChanged = new EventParam<int>(difference);
            OnHealthChanged.Prefix.Invoke(amountChanged);

            
            state->health = isLosingHealth ? currentHealth - amountChanged : currentHealth + amountChanged;


            OnHealthChanged.Postfix.Invoke(amountChanged);
        }
    }
}
