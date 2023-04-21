namespace NoMansSky.Api.Hooks
{
    internal class cGcApplicationGameModeSelectorState_Hooks
    {
        [NMSHook<cGcApplicationGameModeSelectorState.SetupStartUIFunc>]
        public static void SetupStartUIHook()
        {
            IGame.Instance.OnMainMenu.Run();
        }
    }
}
