using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Excalibur.Tests.Cross.Droid
{
    [Activity(
        Label = "Excalibur.Tests.Cross.Droid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
