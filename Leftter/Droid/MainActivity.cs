using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Leftter.Droid
{
	[Activity (Label = "Leftter.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        //ObservableCollection<string> cell = new ObservableCollection<string>();
        ArrayAdapter cell;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button sendButton = FindViewById<Button>(Resource.Id.sendButton);
            EditText sendEditText = FindViewById<EditText>(Resource.Id.sendEditText);
            var logListView = FindViewById<ListView>(Resource.Id.logListView);

            cell = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1);
            logListView.Adapter = cell;


            sendButton.Click += delegate {
                cell.Add(sendEditText.Text);
                logListView.SetSelection(cell.Count - 1);
                sendEditText.Text = string.Empty;
			};
		}
	}
}


