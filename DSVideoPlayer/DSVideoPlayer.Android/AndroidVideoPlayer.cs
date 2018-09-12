using System;

[assembly: Xamarin.Forms.Dependency(typeof(DSVideoPlayer.Droid.AndroidVideoPlayer))]
namespace DSVideoPlayer.Droid
{
    class AndroidVideoPlayer : IVideoPlayer
    {
        public void PlayVideo(string url)
        {
            throw new NotImplementedException();
        }
    }
}