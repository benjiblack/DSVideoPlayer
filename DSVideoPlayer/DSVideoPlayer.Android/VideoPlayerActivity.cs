using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DSVideoPlayer.Droid
{
    [Activity(Label = "VideoPlayerActivity")]
    public class VideoPlayerActivity : Activity
    {
        private VideoView _videoView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_VideoPlayer);
            // Create your application here
            _videoView = FindViewById<VideoView>(Resource.Id.VideoPlayer);
        }
    }
}