using System;
using Xamarin.Forms;

namespace DSVideoPlayer
{
    public partial class MainPage
    {
        readonly IVideoPlayer _videoPlayer = DependencyService.Get<IVideoPlayer>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayVideo(object sender, EventArgs e)
        {
            _videoPlayer.PlayVideo("https://s3.amazonaws.com/digital.cds/mobileapplications/oilyapp/multimedia/chik_fil_a/Oily+App+01-+Fry+the+Chicken.mp4");
        }
    }
}
