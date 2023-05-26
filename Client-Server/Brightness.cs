using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.IO;

namespace Server
{
    public class Brightness
    {
        //Ref:
        //https://www.codeproject.com/Questions/243422/Csharp-Image-Processing-Brightness-Adjustment-Trac

        public Bitmap AdjustBrightness(Image pImage, float pValue)
        {
            Bitmap _tempImage = (Bitmap)pImage;
            Bitmap _newImage = new Bitmap(_tempImage.Width, _tempImage.Height);
            Graphics _newGraphics = Graphics.FromImage(_newImage);

            float _finalValue = pValue / 255.0f;

            float[][] _floatColorMatrix = {
                new float[]{1,0,0,0,0},
                new float[]{0,1,0,0,0},
                new float[]{0,0,1,0,0},
                new float[]{0,0,0,1,0},
                new float[]{_finalValue, _finalValue, _finalValue, _finalValue,1,1}
            };

            ColorMatrix _colormatrix = new ColorMatrix(_floatColorMatrix);

            ImageAttributes _attributes = new ImageAttributes();

            _attributes.SetColorMatrix(_colormatrix);

            _newGraphics.DrawImage(_tempImage, new Rectangle(0, 0,
                _tempImage.Width, _tempImage.Height), 0, 0, _tempImage.Width,
                _tempImage.Height, GraphicsUnit.Pixel, _attributes);

            _attributes.Dispose();
            _newGraphics.Dispose();

            return _newImage;

        }
    }
}
