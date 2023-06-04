using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api;

public static unsafe class Popups
{
    public static void DisplayMessage(string title, string message)
    {
        using var unmanagedTitle = new UnmanagedStringPtr(title);
        //var title = (VirtualString<Size0x20>*)unmanagedTitle.UnmanagedPointer;

        using var unmanagedBody = new UnmanagedStringPtr(message);
        var body = (VirtualString<Size0x20>*)unmanagedBody.UnmanagedPointer;

        IGame.Instance.GetApplication()->data->frontendManager.DisplayMessage(
            (VirtualString<Size0x20>*)unmanagedTitle.UnmanagedPointer,
            (VirtualString<Size0x20>*)unmanagedBody.UnmanagedPointer);
    }
}
