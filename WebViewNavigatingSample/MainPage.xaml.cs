using System;
using Xamarin.Forms;

namespace WebViewNavigatingSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public void Handle_Navigating(object sender, WebNavigatingEventArgs e)
		{
			if (e.Url.StartsWith("https://stackoverflow.com", StringComparison.Ordinal))
				return;

			Device.OpenUri(new Uri(e.Url));

			e.Cancel = true;
		}
	}
}