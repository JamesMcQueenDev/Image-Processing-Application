using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;

namespace GUI
{
    class Controller : IController
    {
        //DECLARE an IFishServer Interface that instansiates a new FishServer Class, called _server.
        private IServerClass _server = new ServerClass();

        /// <summary>
        /// Constructor for the Controller Class.
        /// </summary>
        public Controller()
        {
            //STARTS the GUI Application, sending the Server and FileList as Parameters.
            Application.Run(new PictureApplication(_server));

        }
    }
}
