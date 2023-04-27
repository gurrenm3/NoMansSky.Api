namespace NoMansSky.Api;

public static unsafe class cGcFrontendManagerExtensions
{
    /// <summary>
    /// Display a message popup in game.
    /// </summary>
    /// <param name="manager"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    public static void DisplayMessage(this cGcFrontendManager manager, string title, string message)
    {
        if (title == null)
            title = "";
        if (message == null)
            message = "";

        using var titlePtr = new UnmanagedStringPtr(title);
        using var messagePtr = new UnmanagedStringPtr(message);
        manager.DisplayMessage(titlePtr.UnmanagedPointer, messagePtr.UnmanagedPointer);
    }

    /// <summary>
    /// Display a message popup in game.
    /// </summary>
    /// <param name="manager"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    public static void DisplayMessage(this cGcFrontendManager manager, char* title, char* message)
    {
        manager.DisplayMessage((VirtualString<Size0x20>*)title, (VirtualString<Size0x20>*)message);
    }
}
