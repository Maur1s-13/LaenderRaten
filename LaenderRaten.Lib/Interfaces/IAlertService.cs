using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Interfaces;

public interface IAlertService
{
    void ShowAlert(string title, string message);
    Task ShowALertAsync(string title, string message);

    public void ShowAlertOption(string title, string message, Action<bool> callback);

    Task<bool> ShowALertAsyncOption(string title, string message);

    public bool HandleAlertResult(bool accepted);
}
