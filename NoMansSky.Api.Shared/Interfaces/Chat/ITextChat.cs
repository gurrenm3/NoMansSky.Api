using NoMansSky.Api.Definitions;
using Reloaded.ModHelper;

namespace NoMansSky.Api;

/// <summary>
/// Represents an in game Text Chat box.
/// </summary>
public interface ITextChat : IMemoryObject
{
    /// <summary>
    /// Represents the text input field of a TextChat box.
    /// </summary>
    public ITextChatInput Input { get; }

    /// <summary>
    /// Called when the pointer for this object has been acquired.
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; }

    /// <summary>
    /// Called whenever the Say function is used by the API or the game.
    /// </summary>
    public IModEvent<string> OnSay { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="systemMessage"></param>
    public void Say(string text, bool systemMessage = false);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="systemMessage"></param>
    public void Say(object text, bool systemMessage = false);
}
