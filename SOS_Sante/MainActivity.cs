using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;

namespace SOS_Sante
{
    [Activity(Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var fab = FindViewById<FloatingActionButton>(Resource.Id.FabCall);
            var optionsBtn = FindViewById<Button>(Resource.Id.BtnOption);

            fab.Click += Fab_Click;
            optionsBtn.Click += OptionsBtn_Click;
        }

        private void OptionsBtn_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(OptionsActivity));
        }

        private void Fab_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "You.ve call Nearly Emergency Ambulance", ToastLength.Long).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}