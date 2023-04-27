namespace NoMansSky.Api;

/// <summary>
/// Represents an in game Text Chat box.
/// </summary>
public unsafe class TextChat : ITextChat
{

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IModEvent<long> OnPointerAcquired { get; set; } = new SharedModEvent<long>();

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public long Pointer { get; private set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public ITextChatInput Input { get; private set; }

    private readonly IGameLoop gameLoop;
    private cGcTextChatManager* chatManager;

    public TextChat(IGameLoop gameLoop)
    {
        this.gameLoop = gameLoop;
        Input = new TextChatInput(gameLoop);
        OnPointerAcquired.AddRunner(ptr =>
        {
            if (Pointer == 0)
            {
                Pointer = ptr;
                chatManager = (cGcTextChatManager*)ptr;
            }
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="systemMessage"></param>
    public void Say(object text, bool systemMessage) => Say(text?.ToString(), systemMessage);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <param name="systemMessage"></param>
    public void Say(string text, bool systemMessage)
    {
        if (string.IsNullOrEmpty(text))
            return;

        using var stringPtr = new UnmanagedStringPtr(text);
        var virtualString = (VirtualString<Size0x7F>*)stringPtr.UnmanagedPointer;
        chatManager->Say(virtualString, systemMessage);

        /*var stringPtr = Marshal.StringToHGlobalAnsi(text);
        var virtualStr = (VirtualString<Size0x7F>*)stringPtr;
        chatManager->Say(virtualStr, systemMessage);
        Marshal.FreeHGlobal(stringPtr);*/
    }
}
