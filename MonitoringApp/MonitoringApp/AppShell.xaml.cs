using MonitoringApp.ViewModels;
using MonitoringApp.Views;
using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace MonitoringApp
{
	public partial class AppShell : Microsoft.Maui.Controls.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
