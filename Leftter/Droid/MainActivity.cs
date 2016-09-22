using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

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
			Button sendButton = FindViewById<Button>(Resource.Id.sendButton);
            EditText sendText = FindViewById<EditText>(Resource.Id.sendText);
            EditText logText = FindViewById<EditText>(Resource.Id.logText);

			sendButton.Click += delegate {
                logText.Text += sendText.Text + "\n";
                sendText.Text = string.Empty;
			};
		}
	}
}


