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
    public class Load
    {
        private string _filename;

        public Load()
        {

        }

        /// <summary>
        /// Loads an image into temporary list and returns it
        /// </summary>
        /// <returns></returns>
        public IList<String> LoadImage()
        {
            //DECLARE temporary List to Return to the GUI
            IList<String> _tempList = new List<String>();

            using (OpenFileDialog _openFileDialog = new OpenFileDialog())
            {
                //Directiory in which to open the file
                _openFileDialog.InitialDirectory = "...\\...\\...\\images";
                //Restore the directory to its original form
                _openFileDialog.RestoreDirectory = true;
                //Allow the selection of multiple items at the same time
                _openFileDialog.Multiselect = true;
                //Only show .png images
                _openFileDialog.Filter = "(*.png)|*.png";

                //IF the user clicks OK on the file explorer
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //For each image selected, add the file to _tempList
                    foreach(string _name in _openFileDialog.FileNames)
                    {
                        _filename = _openFileDialog.FileName;
                        _tempList.Add(_name);
                    }
                }
            }
            //RETURN _tempList
            return _tempList;
        }
    }
}
