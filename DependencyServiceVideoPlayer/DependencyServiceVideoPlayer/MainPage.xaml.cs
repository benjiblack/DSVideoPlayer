using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceVideoPlayer
{
    public partial class MainPage : ContentPage
    {
        IVideoPlayer videoPlayer = DependencyService.Get<IVideoPlayer>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayVideo(object sender, EventArgs e)
        {
            videoPlayer.PlayVideo("https://s3.amazonaws.com/digital.cds/mobileapplications/oilyapp/multimedia/Oily+App-+Origins-+Andy\'s+edit.mp4");
        }
    }
}
