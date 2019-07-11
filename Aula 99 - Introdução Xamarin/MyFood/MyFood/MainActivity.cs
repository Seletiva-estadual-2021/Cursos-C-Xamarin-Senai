using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace MyFood
{
    [Activity(Label = "MyFood", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //https://www.youtube.com/watch?v=WBTZ7TSan_E

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ImageView logo = FindViewById<ImageView> (Resource.Id.imgLogo);
            //logo.SetImageBitmap(BitmapFactory.DecodeByteArray()

            int resImage = Resources.GetIdentifier("logo.png", "drawable", PackageName);
            


            //logo.SetImageResource(resImage);
        }
    }
}

