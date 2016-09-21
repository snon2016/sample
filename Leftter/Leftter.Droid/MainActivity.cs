using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Locations;

namespace Leftter.Droid
{
	[Activity (Label = "Leftter.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.SendButton);
            EditText logText = FindViewById<EditText>(Resource.Id.LogText);
            EditText editText = FindViewById<EditText>(Resource.Id.editText);
            

            button.Click += delegate {
                logText.Text += editText.Text + "\n";
                editText.Text = string.Empty;
			};
		}
	}
}


