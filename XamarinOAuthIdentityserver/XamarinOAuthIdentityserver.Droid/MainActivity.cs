using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Auth;

namespace XamarinOAuthIdentityserver.Droid
{
	[Activity (Label = "XamarinOAuthIdentityserver", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new XamarinOAuthIdentityserver.App());

            //// Handle when your app starts
            //var auth = new OAuth2Authenticator(
            //    clientId: "209456986099096",
            //    scope: "",
            //    authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
            //    redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));

            //auth.Completed += (sender, eventArgs) => {
            //    // We presented the UI, so it's up to us to dimiss it on iOS.
            //    // DismissViewController(true, null);

            //    if (eventArgs.IsAuthenticated)
            //    {
            //        // Use eventArgs.Account to do wonderful things
            //    }
            //    else {
            //        // The user cancelled
            //    }
            //};

            //StartActivity(auth.GetUI(this));
        }
	}
}

