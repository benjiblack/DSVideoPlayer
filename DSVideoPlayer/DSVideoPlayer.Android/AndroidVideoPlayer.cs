using Android.Content;
using DependencyServiceVideoPlayer.Droid;
using Plugin.CurrentActivity;

[assembly: Xamarin.Forms.Dependency(typeof(DSVideoPlayer.Droid.AndroidVideoPlayer))]
namespace DSVideoPlayer.Droid
{
    class AndroidVideoPlayer : IVideoPlayer
    {
        public void PlayVideo(string url)
        {
            Intent intent = new Intent(CrossCurrentActivity.Current.AppContext, typeof(VideoPlayerActivity));
            intent.PutExtra(IntentExtraKey.Url, url);
            intent.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}