using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Core.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

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


    }
}
