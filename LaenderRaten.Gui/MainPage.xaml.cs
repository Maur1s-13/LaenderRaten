using LaenderRaten.Core.ViewModels;

namespace LaenderRaten.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage(MainViewModel vw)
        {
            InitializeComponent();
            this.BindingContext = vw;
        }




    }
}
