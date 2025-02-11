﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LaenderRaten.Core.ViewModels
{
    public partial class MainViewModel(IRepository repository, IAlertService alertService, ISoundService soundservice) : ObservableObject
    {


        //Wanting to add Shake animation to Entry when answered wrong
        //Wanting to add Red Border when to Entry when answered wrong
        //Adding Timer




        #region Interfaces
        IRepository _repository = repository;
        IAlertService _alertService = alertService;
        ISoundService _soundService = soundservice;
        #endregion

        #region ObservableProperties
        [ObservableProperty]
        public int? _isplaying = null;

        [ObservableProperty]
        public int _countriesLeft;

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
        public bool mute = false;

        [ObservableProperty]
        public string _eingabe = string.Empty;

        [ObservableProperty]
        public string _imageURL = string.Empty;
        #endregion

        #region Properties
        Land currentCountry {  get; set; }

        private bool EndingGame = false;

        private int currentIndex { get; set; }
        int isPlaying { get; set; }

        public List<Land> remainingCountries;

        
        #endregion

        #region Methods

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

        #region EasyGame
        [RelayCommand]
        public void Easy()
        {
            this.Isplaying = 0;
            this.IsplayingEasy = 0;
            this.Count = 0;
            this.CountriesLeft = 0;

            this.remainingCountries = new List<Land>(this.Countries);

            foreach (var country in this.remainingCountries)
            {
                this.CountriesLeft++;
            }
            this.CountriesLeft += 1;

            ShowNextCountry();

        }
        #endregion

        #region MediumGame
        [RelayCommand]
        public void Medium()
        {
            this.Isplaying = 0;
            this.IsplayingMedium = 0;
            this.Count = 0;

            this.remainingCountries = new List<Land>(this.Countries);
            foreach (var country in this.remainingCountries)
            {
                this.CountriesLeft++;
            }
            this.CountriesLeft += 1;

            ShowNextCountry();
        }
        #endregion

        #region HardGame
        [RelayCommand]
        public void Hard()
        {
            this.Isplaying = 0;
            this.IsplayingHard = 0;
            this.Count = 0;

            this.remainingCountries = new List<Land>(this.Countries);
            foreach (var country in this.remainingCountries)
            {
                this.CountriesLeft++;
            }
            this.CountriesLeft += 1;

            ShowNextCountry();
        }
        #endregion

        #region EndGame
        [RelayCommand]
        public void EndGame()
        {
            _alertService.ShowAlertOption("Warnung!",
                "Sind Sie sicher, dass sie das Quiz frühzeitig beenden wollen?", OnAlertResult);
            

        }
        #endregion

        #region OnAlertResult
        private void OnAlertResult(bool accepted)
        {
            if (accepted)
            {
                this.Isplaying = null;
                this.IsplayingEasy = null;
                this.IsplayingMedium = null;
                this.IsplayingHard = null;
                this.Count = 0;
                this.CountriesLeft = 0;
                this.remainingCountries.Clear();
                this.CountryName = "";
                this.CapitalCity = "";
                this.Continent = "";
            }
            else
            {
                
            }
        }
        #endregion

        #region ShowNextCountry
        private void ShowNextCountry()
        {
            if (remainingCountries.Count > 0)
            {
                Random random = new Random();
                int currentIndex = random.Next(0, remainingCountries.Count);

                currentCountry = remainingCountries[currentIndex];
                this.ImageURL = this.currentCountry.ImageURL;
                remainingCountries.RemoveAt(currentIndex);
                this.CountriesLeft--;
            }
            else
            {
                
                _alertService.ShowAlert("Fertig!",
                    "Aller Länder wurden bereits beantwortet!\n" +
                    $"Sie haben {Count} von {Countries.Count} Länder richtig beantwortet ");
                this.Isplaying = null;
                this.IsplayingEasy = null;
                this.IsplayingMedium = null;
                this.IsplayingHard = null;
                this.Count = 0;
                this.CountriesLeft = 0;
            }
        }
        #endregion

        #region FrageEasyAnsweredCommand

        [RelayCommand]
        public void FrageEasyAnswer(string name)
        {
            

            if (this.CountryName == currentCountry.CountryName)
            {
                this.Count++;
                ShowNextCountry();
                this.CountryName = "";
                _soundService.PlayAudioCorrect();
            }
            else
            {
                _soundService.PlayAudioFail();
                _alertService.ShowAlert("Falsch!",
                    $"Es war {PlaceUmlate(currentCountry.CountryName)} ");
                ShowNextCountry();
                this.CountryName = "";
                
            }
        }
        #endregion

        #region FrageMedium
        [RelayCommand]
        public void FrageMediumAnwer()
        {
            

            if (this.CountryName == currentCountry.CountryName && this.Continent == currentCountry.Continent)
            {
                _soundService.PlayAudioCorrect();
                Count++;
                ShowNextCountry();
                this.CountryName = "";
                this.Continent = "";
            }
            else
            {
                _soundService.PlayAudioFail();
                _alertService.ShowAlert("Falsch!",
                    $"Es war {PlaceUmlate(currentCountry.CountryName)} und {currentCountry.Continent}");
                this.CountryName = "";
                this.Continent = "";
                ShowNextCountry();
            }
        }
        #endregion

        #region FrageHardAnswer
        [RelayCommand]
        public void FrageHardAnswer()
        {
            
            if (this.CountryName == currentCountry.CountryName && 
                this.Continent == currentCountry.Continent &&
                this.CapitalCity == currentCountry.CapitalCity)
            {
                _soundService.PlayAudioCorrect();
                Count++;
                ShowNextCountry();
                this.CountryName = "";
                this.Continent = "";
                this.CapitalCity = "";
            }
            else
            {
                _soundService.PlayAudioFail();
                _alertService.ShowAlert("Falsch!",
                    $"Es war {PlaceUmlate(currentCountry.CountryName)}, {currentCountry.Continent} und {currentCountry.CapitalCity} ");
                this.CountryName = "";
                this.CapitalCity = "";
                this.Continent = "";
                ShowNextCountry();
            }

        }
        #endregion

        #region ReplaceMethods
        public string ReplaceUmlaute(string input)
        {
            string output = input.Replace("ä", "ae")
                              .Replace("ö", "oe")
                              .Replace("ü", "ue")
                              .Replace("Ä", "Ae")
                              .Replace("Ö", "Oe")
                              .Replace("Ü", "Ue")
                              .Replace("ß", "ss");

            return output;
        }

        public string PlaceUmlate(string input)
        {
            string output = input.Replace("ae", "ä")
                              .Replace("oe", "ö")
                              .Replace("ue", "ü")
                              .Replace("Ae", "Ä")
                              .Replace("Oe", "Ö")
                              .Replace("Ue", "Ü");


            return output;
        }
        #endregion

        #region MuteSound
        [RelayCommand]
        public void MuteSound()
        {
            if (Mute == false)
            {
                Mute = true;
                _soundService.MuteSound(Mute);
            }
            else
            {
                Mute = false;
                _soundService.MuteSound(Mute);
            }
        }

        #endregion

        #region Timer
        
        #endregion

        #endregion

    }
}
