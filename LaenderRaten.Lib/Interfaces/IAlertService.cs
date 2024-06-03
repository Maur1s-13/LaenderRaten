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

    void ShowAlertOption(string title, string message);

    Task ShowALertAsyncOption(string title, string message);
}
