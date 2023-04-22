namespace NoMansSky.Api;

/// <summary>
/// Extension methods for <see cref="ITextChatInput"/>.
/// </summary>
public static unsafe class ITextChatInputExtensions
{
    public static cGcTextChatInput* GetGcTextChatInput(this ITextChatInput instance)
    {
        return (cGcTextChatInput*)instance.Pointer;
    }
}
