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
    [Activity(Label = "OptionsActivity")]
    public class OptionsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Optionslayout);
            // Create your application here

            var btnBack = FindViewById<Button>(Resource.Id.imageButtonBack);

            //var listOption = FindViewById<ListMenuItemView>(Resource.Id.listMenuItemViewOptions);

            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}