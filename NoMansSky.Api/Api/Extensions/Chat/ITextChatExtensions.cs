namespace NoMansSky.Api;

/// <summary>
/// Extension methods for <see cref="ITextChat"/>.
/// </summary>
public static unsafe class ITextChatExtensions
{
    public static cGcTextChatManager* GetGcTextChatManager(this ITextChat instance)
    {
        return (cGcTextChatManager*)instance.Pointer;
    }
}
