using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Models
{
    public partial class Land : ObservableObject
    {
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string ImageURL { get; set; }

        public Land(string countryName, string capitalCity, string imageUrl)
        {
                this.CountryName = countryName;
                this.CapitalCity = capitalCity;
                this.ImageURL = imageUrl;
        }
    }
}
