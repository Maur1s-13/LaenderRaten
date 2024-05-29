using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Models
{
    public partial class Land : ObservableObject
    {
        [Key]
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string ImageURL { get; set; }

        public string Continent { get; set; }

        public Land(string countryName, string capitalCity, string imageURL, string continent)
        {
                this.CountryName = countryName;
                this.CapitalCity = capitalCity;
                this.ImageURL = imageURL;
                this.Continent = continent;
        }
    }
}
