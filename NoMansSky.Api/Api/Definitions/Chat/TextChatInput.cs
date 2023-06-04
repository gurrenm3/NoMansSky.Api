using NoMansSky.Api.Hooks;

namespace NoMansSky.Api;

/// <summary>
/// Represents the text input field of a TextChat box.
/// </summary>
public unsafe class TextChatInput : ITextChatInput
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; } = new SharedModEvent<long>();

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IModEvent<string> OnTextChanged { get; set; } = new SharedModEvent<string>();

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public long Pointer { get; private set; }

    private readonly IGameLoop gameLoop;
    private string previousText;
    private cGcTextChatInput* input;

    public TextChatInput(IGameLoop gameLoop)
    {
        this.gameLoop = gameLoop;

        OnPointerAcquired.AddRunner(ptr =>
        {
            if (Pointer == 0)
            {
                Pointer = ptr;
                input = (cGcTextChatInput*) ptr;

                gameLoop.OnUpdate.Before.AddRunner(() =>
                {
                    if (!input->textInputActive)
                        return;

                    var currentText = GetText();
                    if (currentText == previousText)
                        return;

                    OnTextChanged.Run(currentText);
                    previousText = currentText;
                });
            }
        });
    }

    public string GetText()
    {
        if (Pointer == 0)
            return null;

        return input->getText().GetValue();
    }

    public void SetText(string text)
    {
        if (Pointer == 0)
            return;

        input->getInputTextDisplayString().SetValue(text);
        input->getText().SetValue(text);
    }
}
