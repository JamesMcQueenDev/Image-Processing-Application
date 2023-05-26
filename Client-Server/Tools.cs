using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace Server
{
    public class Tools
    {
        Image image;

        public Tools(Image pImage)
        {
            image = pImage;
        }
        public void Rotate90Clockwise()
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        public void Rotate90Anticlockwise()
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        public void FlipX()
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        public void FlipY()
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        public Image Update()
        {
            return image;
        }
    }
}
