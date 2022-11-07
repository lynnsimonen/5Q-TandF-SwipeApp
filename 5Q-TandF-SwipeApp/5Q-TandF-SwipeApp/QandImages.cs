using System;
using System.Collections.Generic;
using System.Text;

namespace _5Q_TandF_SwipeApp
{
    class QandImages
    {
        public string Question { get; set; }
        public string ImageAmer { get; set; }
        public string ImageFrench { get; set; }

        public QandImages(string question, string image, string image2)
        {
            this.Question = question;
            this.ImageAmer = image;
            this.ImageFrench = image2;
        }

    }

}
