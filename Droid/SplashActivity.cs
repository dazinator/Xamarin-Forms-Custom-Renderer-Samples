using Android.App;
using Android.Support.V7.App;

namespace Samples.Droid
{

    [Activity(Label = "Samples.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
           // Finish();
        }
    }
}

