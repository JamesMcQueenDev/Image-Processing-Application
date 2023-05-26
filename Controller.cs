using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MVC
{
    public class Controller
    {
        IFactoryLoacator _factories;

        ICommandInvoker _commandInvoker;

        IDictionary<int, Form> _characterView;

        public Controller(IFactoryLoacator factories)
        {

            _factories = factories;

            _commandInvoker = (_factories.Get<ICommandInvoker>() as IFactoryLoacator<ICommandInvoker>).Create<_commandInvoker>();


        }
    }
}

