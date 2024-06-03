using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

            this.remainingCountries = new List<Land>(this.Countries);

        }
        #endregion

        [RelayCommand]
        public void Easy()
        {
            //ToLower Eingabe
            //Umlaute!!
            //Bild kleiner machen


            this.Isplaying = 0;
            this.IsplayingEasy = 0;
            this.Count = 0;

            for (int i = 0; i < this.Countries.Count; i++)
            {
                Random random = new Random();
                int gen = random.Next(1, this.Countries.Count + 1);

                currentCountry = _repository.Find(gen);


                this.ImageURL = this.currentCountry.ImageURL;

                FrageEasy(this.Eingabe);

               
                
            }

        }

        [RelayCommand]
        public void FrageEasy(string name)
        {
            if (name == currentCountry.CountryName)
            {
                this.Count++;
                ShowNextCountry();
            }

            

            
        }

        


        public void ShowNextCountry()
        {
            if (remainingCountries.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, remainingCountries.Count);

                currentCountry = remainingCountries[index];
                this.ImageURL = this.currentCountry.ImageURL;

                // Remove the selected country from the list
                remainingCountries.RemoveAt(index);
            }
            else
            {
                
            }
        }




    }
}
