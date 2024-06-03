using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaenderRaten.Core.ViewModels
{
    public partial class MainViewModel(IRepository repository, IAlertService alertService) : ObservableObject
    {

        IRepository _repository = repository;
        IAlertService _alertService = alertService;
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

        [ObservableProperty]
        public int _count = 0;

        [ObservableProperty]
        public string _countryName = string.Empty;

        [ObservableProperty]
        public string _capitalCity = string.Empty;

        [ObservableProperty]
        public string _continent = string.Empty;

        [ObservableProperty]
        public string _eingabe = string.Empty;

        [ObservableProperty]
        public string _imageURL = string.Empty;

       
        Land currentCountry {  get; set; }

        private bool EndingGame = false;

        private int currentIndex { get; set; }
        int isPlaying { get; set; }

        private List<Land> remainingCountries;

        #region loadCommand
        [RelayCommand]
        public void Load()
        {
            this.Countries.Clear();

            var countries = _repository.GetAll();

            foreach (var country in countries)
            {
                this.Countries.Add(country);
                
            }

            

        }
        #endregion

        [RelayCommand]
        public void Easy()
        {
            this.Isplaying = 0;
            this.IsplayingEasy = 0;
            this.Count = 0;

            this.remainingCountries = new List<Land>(this.Countries);

            ShowNextCountry();

        }
        [RelayCommand]
        public void EndGame()
        {
            _alertService.ShowAlertOption("Warnung!",
                "Sind Sie sicher, dass sie das Quiz frühzeitig beenden wollen?", OnAlertResult);

        }

        private void OnAlertResult(bool accepted)
        {
            if (accepted)
            {
                this.Isplaying = null;
                this.IsplayingEasy = null;
                this.Count = 0;
            }
            else
            {
                
            }
        }



        private void ShowNextCountry()
        {
            if (remainingCountries.Count > 0)
            {
                Random random = new Random();
                int currentIndex = random.Next(0, remainingCountries.Count);

                currentCountry = remainingCountries[currentIndex];
                this.ImageURL = this.currentCountry.ImageURL;
                remainingCountries.RemoveAt(currentIndex);
            }
            else
            {
                
                _alertService.ShowAlert("Fertig!",
                    "Aller Länder wurden bereits beantwortet!");
                this.Isplaying = null;
                this.IsplayingEasy = null;
                this.Count = 0;
            }
        }

        [RelayCommand]
        public void FrageEasyAnswer(string name)
        {
            if (name == currentCountry.CountryName)
            {
                this.Count++;
                ShowNextCountry();
            }
            else
            {
                ShowNextCountry();
            }
        }

       
    }
}
