using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Core.ViewModels
{
    public partial class MainViewModel(IRepository repository) : ObservableObject
    {

        IRepository _repository = repository;
        // Leichter, Mittlerer, Schwerer Modus
        // Land per Random
        // Land kann nur einmal pro Runde vorkommen
        // Feedback wie viele Länder richtig beantwortet wurden/falsch

        [ObservableProperty]
        public int? _isplaying = null;

        [ObservableProperty]
        public int? _isplayingEasy = null;

        [ObservableProperty]
        public int? _isplayingMedium = null;

        [ObservableProperty]
        public int? _isplayingHard = null;

        [ObservableProperty]
        public List<Land> _countries = new List<Land>();

        [RelayCommand]
        public void Load()
        {

            var countries = 

        }


        [RelayCommand]
        public void Easy()
        {
            Random random = new Random();
            int gen = random.Next(0, 10);


        }


    }
}
