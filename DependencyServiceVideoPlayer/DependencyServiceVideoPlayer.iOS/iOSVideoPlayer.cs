﻿using AVFoundation;
using AVKit;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceVideoPlayer.iOS.iOSVideoPlayer))]
namespace DependencyServiceVideoPlayer.iOS
{
    class iOSVideoPlayer : IVideoPlayer
    {
        public void PlayVideo(string url)
        {
            var player = new AVPlayer(new NSUrl(url));
            var controller = new AVPlayerViewController
            {
                Player = player
            };

            var rootViewController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            rootViewController.PresentViewController(controller, true, () => player.Play());
        }
    }
}