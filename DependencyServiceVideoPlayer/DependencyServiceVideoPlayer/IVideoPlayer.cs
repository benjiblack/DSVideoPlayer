using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServiceVideoPlayer
{
    public interface IVideoPlayer
    {
        void PlayVideo(string url);
    }
}
