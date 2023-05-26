using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;

namespace GUI
{
    public partial class PictureApplication : Form , IInitLoadDel
    {
        private LoadDelegate _loadDel;   
        private Image _currentImage;
        private Load _load;
        private Save _save;
        private Brightness _brightness;
        private IServerClass _server;
        private int _position;
        private string _noImage = "No Image Loaded";
        private string _calledImage;

        private float brightnessLevel = 50;

        private int adjustmentNumber;

        private IDictionary<int, String> _tempDictionary;

        /// <summary>
        /// 
        /// </summary>
        public PictureApplication(IServerClass pServer)
        {
            InitializeComponent();
            _server = pServer;
            _load = new Load();
            _save = new Save();
            _tempDictionary = new Dictionary<int, String>();
            _position = 0;
        }

        /// <summary>
        /// Call to server to rotate Clockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockwiseRotate_Click(object sender, EventArgs e)
        {
            //EXCEPTION
            try
            {
                _server.RotateClockwiseImage(_calledImage);
                Update();
            }
            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnticlockwiseRotate_Click(object sender, EventArgs e)
        {
            //EXCEPTION
            try
            {
                _server.RotateAnticlockwiseImage(_calledImage);
                Update();
            }
            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        /// Call to Server to rotate Anticlockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipY_Click(object sender, EventArgs e)
        {
            //EXCEPTION
            try
            {
                _server.VerticalFlipImage(_calledImage);
                Update();
            }
            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        /// Call to Server to Flip on the X-Axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipX_Click(object sender, EventArgs e)
        {
            //EXCEPTION
            try
            {
                _server.HorizontalFlipImage(_calledImage);
                Update();
            }
            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        /// Call to Server to Flip on the Y-Axis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            foreach(string result in _server.Load(_load.LoadImage()))
            {
                
                //if (_tempDictionary.Contains(string result in _server.Load(_load.LoadImage()))
                //{
                //    //Do nothing
                //}
                //else
                //{
                //    _tempDictionary.Add(_position, result);
                //    _position++;
                //}


                _position++;
                _tempDictionary.Add(_position, result);
       
            }

            _position = 1;
            Update();
        }

        /// <summary>
        /// Exports the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show(_noImage);
            }
            else
            {
                _save.SaveImage(_currentImage);
            }
        }

        /// <summary>
        /// Updates the image, calling for GetImage() in server and updating the variables accordingly
        /// </summary>
        private void Update()
        {
            _calledImage = _tempDictionary[_position];
            _currentImage = _server.GetImage(_calledImage, PictureBox.Width, PictureBox.Height);
            PictureBox.Image = _currentImage;
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Console.WriteLine(_position);
            ResolutionLabel.Text = "X:" + _currentImage.Width + "px" + " Y:" + _currentImage.Height + "px";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Cycles back through the dictionary, and displaying the images to screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (_position <= 1)
                {
                    _position = _tempDictionary.Count();
                }
                else
                {
                    _position--;
                }
                Update();
            }

            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        ///  Cycles forward through the dictionary, and displaying the images to screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (_position >= _tempDictionary.Count())
                {
                    _position = 1;
                }
                else
                {
                    _position++;
                }

                Update();
            }

            catch
            {
                MessageBox.Show(_noImage);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pLd"></param>
        public void Initialize(LoadDelegate pLd)
        {
            _loadDel = pLd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleDown_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScaleUp_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrightnessStepDown_Click(object sender, EventArgs e)
        {
            brightnessLevel = brightnessLevel - 10;
            Update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrightnessStepUp_Click(object sender, EventArgs e)
        {
            brightnessLevel = brightnessLevel + 10;
            Update();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContrastStepDown_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContrastStepUp_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaturationStepDown_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaturationStepUp_Click(object sender, EventArgs e)
        {

        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void redoButton_Click(object sender, EventArgs e)
        {

        }
    }
}