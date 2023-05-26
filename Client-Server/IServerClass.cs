using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IServerClass
    {
        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the Server's data store.
		/// The strings in the collection act as unique identifiers for images in the Server's data store.
        /// </summary>
        /// <param name="pPathfilenames">a collection of one or more strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        IList<String> Load(IList<String> pPathfilenames);

        /// <summary>
        /// Request a copy of the image specified by 'pUid', scaled according to the dimensions given by pFrameWidth and pFrameHeight.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image requested</param>
        /// <param name="pFrameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="pFrameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image identified by pUid</returns>
        Image GetImage(String pUid, int pFrameWidth, int pFrameHeight);

        /// <summary>
        /// Rotate the image clockwise specified by 'pUid'.
        /// The client will need to request a copy of the Image to update its view-copy of the image accordingly.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be rotated</param>
        /// <returns>the rotated Image</returns>
        void RotateClockwiseImage(String pUid);

        /// <summary>
        /// Rotate the image anticlockwise specified by 'pUid'.
        /// The client will need to request a copy of the Image to update its view-copy of the image accordingly.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be rotated</param>
        /// <returns>the rotated Image</returns>
        void RotateAnticlockwiseImage(String pUid);

        /// <summary>
        /// Flip the image specified by 'pUid' horizontally.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be flipped</param>
        /// <returns>the flipped Image</returns>
        void HorizontalFlipImage(String pUid);

        /// <summary>
        /// Flip the image specified by 'pUid' vertically.
        /// </summary>
        /// <param name="pUid">the unique identifier for the image to be flipped</param>
        /// <returns>the flipped Image</returns>
        void VerticalFlipImage(String pUid);
    }
}