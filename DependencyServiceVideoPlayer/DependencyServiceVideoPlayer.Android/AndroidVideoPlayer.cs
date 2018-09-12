using System;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceVideoPlayer.Droid.AndroidVideoPlayer))]
namespace DependencyServiceVideoPlayer.Droid
{
    class AndroidVideoPlayer : IVideoPlayer
    {
        public void PlayVideo(string url)
        {
            throw new NotImplementedException();
        }
    }
}