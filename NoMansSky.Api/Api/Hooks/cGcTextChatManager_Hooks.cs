namespace NoMansSky.Api;

internal unsafe class cGcTextChatManager_Hooks
{
    [NMSHook<cGcTextChatManager.ConstructFunc>]
    public static void cGcTextChatManager_ConstructFunc(long self)
    {
        IGame.Instance.TextChat.OnPointerAcquired.Run(self);
    }

    [NMSHook<cGcTextChatManager.SayFunc>]
    public static void cGcTextChatManager_SayFunc(long self, long messageBody, bool systemMessage)
    {
        var message = StringUtils.ToString(messageBody);
        ConsoleUtils.WriteLine($"Message from hook: {message.ToString()}");
        IGame.Instance.TextChat.OnSay.Run(message);
    }
}
