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

namespace GUI
{
    public class Save
    {
        public Save()
        {

        }

        /// <summary>
        /// Saves the image to desktop
        /// </summary>
        /// <param name="pSaveImage"></param>
        public void SaveImage(Image pSaveImage)
        {
            //DECLARE and Image, call it _saveImage
            Image _saveImage = pSaveImage;

            using (SaveFileDialog _saveFileDialog = new SaveFileDialog())
            {
                //INSTANTIATE the inital file
                _saveFileDialog.InitialDirectory = "\\C:\\Users\\...\\Pictures";
                //RETURN the directory
                _saveFileDialog.RestoreDirectory = true;
                //INSTANTIATE the file name
                _saveFileDialog.FileName = "untitled";
                //Only show .png images
                _saveFileDialog.Filter = "(*.png)|*.png";

                //IF the user clicks the OK button in file explorer
                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //SAVE the image
                    _saveImage.Save(_saveFileDialog.FileName);
                }
            }
        }
    }
}
