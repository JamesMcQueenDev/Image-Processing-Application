using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    public class ServerClass : IServerClass
    {
        //DELCARE a dictionary for the Server to store the loaded images, call it _storedImageDictionary
        IDictionary<String, Image> _storedImageDictionary;

        public ServerClass()
        {
            //INSTANTIATE _storedImageDictionary
            _storedImageDictionary = new Dictionary<String, Image>();
        }
        
        /// <summary>
        /// Returns specified Image in the dictionary 
        /// </summary>
        /// <param name="pUid"></param>
        /// <param name="pFrameWidth"></param>
        /// <param name="pFrameHeight"></param>
        /// <returns></returns>
        public Image GetImage(string pUid, int pFrameWidth, int pFrameHeight)
        {
            //RETURN the _storedImageDictionary
            return _storedImageDictionary[pUid];
        }

        /// <summary>
        /// Returns filepath of the image list to the GUI
        /// </summary>
        /// <param name="pPathfilenames"></param>
        /// <returns></returns>
        public IList<string> Load(IList<string> pPathfilenames)
        {
            //FOREACH image in the _storedImageDictionary
            foreach (string position in pPathfilenames)
            {
                //ADD the file path, assign it variable position
                _storedImageDictionary.Add(position, Image.FromFile(Path.GetFullPath(position)));
                //PRINT position to console
                Console.WriteLine(position);
            }
            //RETURN pPathfilenames
            return pPathfilenames;
        }

        /// <summary>
        /// Rotates the stored image in a clockwise orientation
        /// </summary>
        /// <param name="pUid"></param>
        public void RotateClockwiseImage(string pUid)
        {
            //ROTATE the image clockwise
            _storedImageDictionary[pUid].RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        /// <summary>
        /// Rotates the stored image in an anticlockwise orientation
        /// </summary>
        /// <param name="pUid"></param>
        public void RotateAnticlockwiseImage(string pUid)
        {
            //ROTATE the image anti clockwise
            _storedImageDictionary[pUid].RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        /// <summary>
        /// Flips image on the Y-Axis
        /// </summary>
        /// <param name="pUid"></param>
        public void VerticalFlipImage(string pUid)
        {
            //FLIP the image vertically
            _storedImageDictionary[pUid].RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        /// <summary>
        /// Flips image on the X-Axis
        /// </summary>
        /// <param name="pUid"></param>
        public void HorizontalFlipImage(string pUid)
        {
            //FLIP the image horizontally
            _storedImageDictionary[pUid].RotateFlip(RotateFlipType.RotateNoneFlipY);
        }
    }
}