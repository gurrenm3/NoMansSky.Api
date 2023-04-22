using NoMansSky.Api.Definitions;
using Reloaded.ModHelper;

namespace NoMansSky.Api;

/// <summary>
/// Represents the text input field of a TextChat box.
/// </summary>
public interface ITextChatInput : IMemoryObject
{
    /// <summary>
    /// Called when the pointer for this object has been acquired.
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; }

    /// <summary>
    /// Called whenever the text is changed in this input field.
    /// </summary>
    public IModEvent<string> OnTextChanged { get; set; }

    /// <summary>
    /// Returns the text that is currently in the text input.
    /// </summary>
    /// <returns></returns>
    public string GetText();

    /// <summary>
    /// Sets the text that is currently in the text input.
    /// </summary>
    /// <param name="text"></param>
    public void SetText(string text);
}
