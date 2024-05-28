using LaenderRaten.Core.ViewModels;

namespace LaenderRaten.Gui.Pages;

public partial class AddCountry : ContentPage
{
	public AddCountry(AddCountryViewModel vw)
	{
		InitializeComponent();
		this.BindingContext = vw;
	}
}