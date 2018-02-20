using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.OS;

namespace Samples.Droid
{
    [Activity(Label = "Samples.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme",
         LaunchMode = LaunchMode.SingleTop,
       ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static Android.Support.V7.Widget.Toolbar ToolBar
        {
            get; private set;
        }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
           
            LoadApplication(new ReproPrismApp());
           // LoadApplication(new App());

            // Grab this for later - we have a custom renderer that need a ref to the toolbar so it can 
           // manually inflate some menu items within in.
            ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
          //  var searchView = FindViewById<SearchView>(Resource.Id.mySearchBar);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}
