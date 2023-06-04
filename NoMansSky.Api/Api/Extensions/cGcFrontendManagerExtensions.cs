namespace NoMansSky.Api;

public static unsafe class cGcFrontendManagerExtensions
{
    /// <summary>
    /// Display a message popup in game.
    /// </summary>
    /// <param name="manager"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    public static void DisplayMessage(this cGcFrontendManager manager, string titleText, string messageText)
    {
        using var unmanagedTitle = new UnmanagedStringPtr("Hello!");
        var title = (VirtualString<Size0x20>*)unmanagedTitle.UnmanagedPointer;

        using var unmanagedBody = new UnmanagedStringPtr("This is a message!");
        var body = (VirtualString<Size0x20>*)unmanagedBody.UnmanagedPointer;
        manager.DisplayMessage(title, body);

        /*if (title == null)
            title = "";
        if (message == null)
            message = "";

        var titlePtr = new UnmanagedStringPtr(title);
        var messagePtr = new UnmanagedStringPtr(message);

        var titleStr = (VirtualString<Size0x20>*)titlePtr.UnmanagedPointer;
        var bodyStr = (VirtualString<Size0x20>*)messagePtr.UnmanagedPointer;
        manager.DisplayMessage(titleStr, bodyStr);

        titlePtr.Dispose();
        messagePtr.Dispose();*/
    }

    /// <summary>
    /// Display a message popup in game.
    /// </summary>
    /// <param name="manager"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    /*public static void DisplayMessage(this cGcFrontendManager manager, char* title, char* message)
    {
        manager.DisplayMessage((VirtualString<Size0x20>*)title, (VirtualString<Size0x20>*)message);
    }*/
}
