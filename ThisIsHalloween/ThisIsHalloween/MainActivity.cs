using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace ThisIsHalloween
{
	[Activity(Label = "ThisIsHalloween", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;
		MediaPlayer player;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			player = MediaPlayer.Create(this, Resource.Raw.eye);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button>(Resource.Id.MyButton);

			//button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

			Button buffyButton = FindViewById<Button>(Resource.Id.btnBuffy);
			buffyButton.Click += delegate { player.Start(); };

			




		}
	}
}

