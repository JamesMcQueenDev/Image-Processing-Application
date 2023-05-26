using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Load
    {
        Image image;
        public string filepath, filename;

        public Load()
        {

        }

        public Image LoadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "...\\...\\...\\images";

                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    filename = Path.GetFileName(filepath);
                    image = Image.FromFile(filepath);
                }
            }
            return image;
        }

        public String GetFilepath()
        { 
            return filepath;
        }

        public String GetFilename()
        {
            return filename;
        }

        public void SaveImage(Image pSaveImage)
        {
            Image saveImage = pSaveImage;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "untitled";
                saveFileDialog.Filter = "(*.png)|*.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveImage.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
