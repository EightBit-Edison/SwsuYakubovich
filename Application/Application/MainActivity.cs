using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace Application
{
    [Activity(Label = "Application", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            WebView mWebView = FindViewById<WebView>(Resource.Id.webView1);

            button.Click += delegate {
                mWebView.Settings.JavaScriptEnabled = true;
                mWebView.LoadUrl("http://www.google.com");
            };
        }
    }
}

