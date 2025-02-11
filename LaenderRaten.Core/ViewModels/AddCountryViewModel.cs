﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LaenderRaten.Lib.Models;
using LaenderRaten.Lib.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using System.Collections.ObjectModel;
using System.Xml;

namespace LaenderRaten.Core.ViewModels
{
    public partial class AddCountryViewModel(IRepository repository, IAlertService alertService, ILoadRepository loadRepository) : ObservableObject
    {
        IRepository _repository = repository;
        IAlertService _alertService = alertService;
        ILoadRepository _loadRepository = loadRepository;
        
        //Same country cant be added twice
        //update Method
        //Adding shakes to add Button when cannot be added

        [ObservableProperty]
        public string countryName;

        [ObservableProperty]
        public int count;

        [ObservableProperty]
        public string capitalCity;

        [ObservableProperty]
        public string imageURL;

        [ObservableProperty]
        public string continent;

        [ObservableProperty]
        ObservableCollection<Land> _countries = [];

        [ObservableProperty]
        Land _selectedcountry = null;

        #region CRUD-Methods
        #region Add
        [RelayCommand]
        public void Add()
        {
            this.CountryName = ReplaceUmlaute(this.CountryName);

            var trimmed = RemoveSpace(this.CountryName);

            this.ImageURL = trimmed + ".png";

            if (this.Count < 195)
            {
                Land country = new(this.CountryName, this.CapitalCity, this.ImageURL.ToLower(), this.Continent); ;

                var result = _repository.Add(country);

                if (result)
                {
                    country.CountryName = PlaceUmlate(country.CountryName);
                    this.Countries.Add(country);
                    this.CountryName = string.Empty;
                    this.CapitalCity = string.Empty;
                    this.Continent = string.Empty;

                }
            }
            else
            {
                _alertService.ShowAlert("Fehler!",
                    "Es existieren nur 195 Länder");
            }
            
        }
        #endregion

        #region Delete
        [RelayCommand]
        public void Delete()
        {
            _repository.Delete(Selectedcountry);
            Countries.Remove(Selectedcountry);  
        }
        #endregion

        #region Update
        [RelayCommand]
        public void Update()
        {
            var land = Selectedcountry;

            _repository.Update(land);
            _alertService.ShowAlert("Erfolg",
                "Land wurde ausgebessert!");
        }
        #endregion
        #endregion

        #region AddCount
        [RelayCommand]
        void AddCount()
        {
            this.Count = 0;

            var countries = _repository.GetAll();

            foreach (var country in countries)
            {
                this.Count += 1;
            }
        }
        #endregion

        #region LoadCommand
        [RelayCommand]
        public void Load()
        {
            this.Countries.Clear();

            var laender = _repository.GetAll();

            foreach (var country in laender)
            {
                country.CountryName=  PlaceUmlate(country.CountryName);
                this.Countries.Add(country);
            }
        }


        [RelayCommand]
        public void LoadAllCountries()
        {
            this.Countries.Clear();

            var laenderToDelte = _repository.GetAll();

            foreach (var item in laenderToDelte)
            {
                _repository.Delete(item);
            }

            var laender = _loadRepository.LoadAll();

            foreach (var item in laender)
            {
                this.Countries.Add(item);
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

        public string RemoveSpace(string input)
        {
            string output = input.Replace(" ", "");

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
    }
}
