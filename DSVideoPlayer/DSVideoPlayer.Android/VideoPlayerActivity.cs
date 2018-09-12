using Android.App;
using Android.OS;
using Android.Widget;
using DependencyServiceVideoPlayer.Droid;
using Uri = Android.Net.Uri;

namespace DSVideoPlayer.Droid
{
    //The ConfigurationChanges attributes retains state on rotation. Theme removed action bar and status bar.
    [Activity(Label = "VideoPlayerActivity", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen",
        ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize),]
    public class VideoPlayerActivity : Activity
    {
        private VideoView _videoView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_VideoPlayer);

            //Get VideoView by ID
            _videoView = FindViewById<VideoView>(Resource.Id.VideoPlayer);

            //Set MediaController for videoView
            _videoView.SetMediaController(new MediaController(this));

            //Get the URL from the intent.
            var url = Intent.GetStringExtra(IntentExtraKey.Url) ?? "";

            //Set Uri source by parsing url
            _videoView.SetVideoURI(Uri.Parse(url));

            //Start playback
            _videoView.Start();
        }
    }
}