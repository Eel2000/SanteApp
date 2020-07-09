using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SOS_Sante
{
    [Activity(Label = "ActivitySplash",MainLauncher =true, Theme = "@style/SplashTheme",NoHistory =true)]
    public class ActivitySplash : Activity
    {
        protected override void OnResume()
        {
            base.OnResume();
            Thread.Sleep(2000);
            StartActivity(typeof(MainActivity));
        }
    }
}