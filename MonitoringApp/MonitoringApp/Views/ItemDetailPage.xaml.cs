using MonitoringApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MonitoringApp.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}