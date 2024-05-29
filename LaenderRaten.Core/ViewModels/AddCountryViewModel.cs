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

namespace LaenderRaten.Core.ViewModels
{
    public partial class AddCountryViewModel(IRepository repository) : ObservableObject
    {
        IRepository _repository = repository;
        
        //Liste aller Länder anzeigen 
        //Länder die bereits hinzugefügt worden sind mit grünen Text anzeigen
        //Per Imagebutton anzeigen lassen
        //ImageSource ist gegeben png name ist name des Landes
        //ä ö Ü ß alle zue umlaute

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


        [RelayCommand]
        public void Add()
        {
            this.CountryName = ReplaceUmlaute(this.CountryName);
            
            this.ImageURL = this.CountryName + ".png";

            Land country = new(this.CountryName, this.CapitalCity, this.ImageURL.ToLower(), this.Continent);

            var result = _repository.Add(country);

            if (result)
            {
                this.CountryName = string.Empty;
                this.CapitalCity = string.Empty;
                this.Continent = string.Empty;
            }


        }

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
    }
}
