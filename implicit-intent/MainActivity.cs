using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using System;

namespace implicit_intent
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button sms, website, email, call;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Init();
            AddClicks();
        }

        private void AddClicks()
        {
            sms.Click += Sms_Click;
            website.Click += Website_Click;
            email.Click += Email_Click;
            call.Click += Call_Click;
        }

        private void Call_Click(object sender, EventArgs e)
        {
        }

        private void Email_Click(object sender, EventArgs e)
        {
        }

        private void Website_Click(object sender, EventArgs e)
        {
        }

        private void Sms_Click(object sender, EventArgs e)
        {
            string msg = "Hello, test message";
            string phoneNum = "YUOR_PHONE_NUMBER";
            var smsIntent = new Intent(Intent.ActionView, Android.Net.Uri.Parse("sms:" + phoneNum));
            smsIntent.PutExtra("sms_body", msg);
            StartActivity(smsIntent);
        }

        private void Init()
        {
            sms = FindViewById<Button>(Resource.Id.smsBtn);
            website = FindViewById<Button>(Resource.Id.webBtn);
            email = FindViewById<Button>(Resource.Id.emailBtn);
            call = FindViewById<Button>(Resource.Id.callBtn);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
