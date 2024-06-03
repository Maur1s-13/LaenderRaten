using LaenderRaten.Core.ViewModels;
using LaenderRaten.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Gui.Services;

public class AlertService : IAlertService
{
    #region noOption
    public async void ShowAlert(string title, string message)
    {
        Application.Current.MainPage.Dispatcher.Dispatch(async () => {
            await ShowALertAsync(title, message);
        });

    }

    public Task ShowALertAsync(string title, string message)
    {
        return Application.Current.
                MainPage.DisplayAlert(title, message, "OK");
    }
    #endregion



    #region Option
    public async void ShowAlertOption(string title, string message, Action<bool> callback)
    {
        Application.Current.MainPage.Dispatcher.Dispatch(async () => {
            bool result = await ShowALertAsyncOption(title, message);
            callback(result);
        });

    }

    public Task<bool> ShowALertAsyncOption(string title, string message)
    {
        return Application.Current.
                MainPage.DisplayAlert(title, message, "OK", "Abbrechen");
        
    }

    public bool HandleAlertResult(bool accepted)
    {
        if (accepted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    

    #endregion


}
