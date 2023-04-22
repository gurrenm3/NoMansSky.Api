namespace NoMansSky.Api;

internal unsafe class cGcTextChatManager_Hooks
{
    [NMSHook<cGcTextChatManager.ConstructFunc>]
    public static void cGcTextChatManager_ConstructFunc(long self)
    {
        IGame.Instance.TextChat.OnPointerAcquired.Run(self);
    }
}
