using CommunityToolkit.Mvvm.ComponentModel;
using LaenderRaten.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Gui.Services
{
    public class TimerViewmodel : ITimerRepository
    {
        private readonly IDispatcherTimer _dispatcherTimer;
        private DateTime _startTime;

        public TimerViewmodel()
        {
            
            _dispatcherTimer = Application.Current.Dispatcher.CreateTimer();
            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            _dispatcherTimer.Tick += OnDispatcherTimerTick;
        }

        
        private string elapsedTime;

        
        private void StartTimer()
        {
            _startTime = DateTime.Now;
            _dispatcherTimer.Start();
        }

       
        private void StopTimer()
        {
            _dispatcherTimer.Stop();
        }

        private void OnDispatcherTimerTick(object sender, EventArgs e)
        {
            this.elapsedTime = (DateTime.Now - _startTime).ToString(@"hh\:mm\:ss");
        }

        public void InitializeTimer()
        {
            _startTime = DateTime.Now;
            this.elapsedTime = "00:00:00";
        }
    }
}
