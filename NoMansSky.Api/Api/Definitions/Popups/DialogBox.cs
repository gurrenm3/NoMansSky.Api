using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api;

public unsafe class DialogBox
{
    public delegate void OnClosedCallback(void* a1, bool a2, bool a3);
    public string boxName;
    public string title;
    public string message;
    public OnClosedCallback onClosed;

    public void Show()
    {

    }

    private void Show(string boxName, string title, string message, OnClosedCallback onClosedFunc, void* onCloseData, bool isSoft)
    {
        //IGame.Instance.GetApplication()->data->frontendManager->ShowDialogBox()
    }
}
