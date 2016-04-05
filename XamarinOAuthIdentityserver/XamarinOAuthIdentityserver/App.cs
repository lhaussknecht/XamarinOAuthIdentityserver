using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Widget;
using Xamarin.Auth;
using Xamarin.Forms;

namespace XamarinOAuthIdentityserver
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            // Handle when your app starts
            var auth = new OAuth2Authenticator(
                clientId: "209456986099096",
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));

            auth.Completed += (sender, eventArgs) => {
                // We presented the UI, so it's up to us to dimiss it on iOS.
                // DismissViewController(true, null);

                if (eventArgs.IsAuthenticated)
                {
                    MainPage.DisplayAlert(eventArgs.Account.Username, "Cool", "Cancel");
                    // Use eventArgs.Account to do wonderful things
                }
                else {
                    // The user cancelled
                }
            };

           global::Xamarin.Forms.Forms.Context.StartActivity(auth.GetUI(global::Xamarin.Forms.Forms.Context));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
