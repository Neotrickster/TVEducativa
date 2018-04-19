using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TVEducativa.Views;
using Xamarin.Forms;

namespace TVEducativa
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new TVEducativaCanales();
		    //MainPage = new FullScreenTest();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
