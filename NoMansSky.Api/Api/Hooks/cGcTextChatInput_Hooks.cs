namespace NoMansSky.Api.Hooks;

internal class cGcTextChatInput_Hooks
{
    public static IModEvent OnTextChatInputUpdated = new ModEvent();

    [NMSHook<cGcTextChatInput.ConstructFunc>]
    public static void cGcTextChatInput_ConstructFunc(long self)
    {
        IGame.Instance.TextChat.Input.OnPointerAcquired.Run(self);
    }
}
