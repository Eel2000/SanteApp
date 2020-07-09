using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.View.Menu;
using Android.Views;
using Android.Widget;

namespace SOS_Sante
{
    [Activity(Label = "OptionsActivity",Theme = "@style/CustomTheme")]
    public class OptionsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Optionslayout);
            // Create your application here

           var btnBack = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var btnSignIn = FindViewById<Button>(Resource.Id.buttonSignIn);
            var btnSinUp = FindViewById<Button>(Resource.Id.buttonSignUp);

            //var listOption = FindViewById<ListMenuItemView>(Resource.Id.listMenuItemViewOptions);

            btnBack.Click += BtnBack_Click;
            btnSignIn.Click += BtnSignIn_Click;
            btnSinUp.Click += BtnSinUp_Click;
        }

        private void BtnSinUp_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You'll Sign in On clicking on this button", ToastLength.Short).Show();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "You'll Sign Up On clicking on this button", ToastLength.Short).Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var intentBack = new Intent(this, typeof(MainActivity))
                .SetFlags(ActivityFlags.ReorderToFront);
            
            StartActivity(intentBack);
        }
    }
}