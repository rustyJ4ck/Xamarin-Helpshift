using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelpShiftTest
{
    [Activity(Label = "HelpShiftTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			//Xamarin.Android.HS.Helpshift
			Xamarin.Android.Helpshift.HS.Install(Application, 
				"2d51035ff48350986b8a269a6403801b", 
				"test.helpshift.com", 
				"test-90a6819405166f4");

			Button button = FindViewById<Button>(Resource.Id.Button1);

			button.Text = "Show conversations";
            button.Click += delegate {
				Xamarin.Android.Helpshift.HS.ShowConversation(this);
            };

			button = FindViewById<Button>(Resource.Id.Button2);
			button.Text = "Show faqs";
			button.Click += delegate {
				Xamarin.Android.Helpshift.HS.ShowFAQs(this);
			};
        }
    }
}


