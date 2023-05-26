using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jack Hughes, James McQueen & Marc Price
/// Date: 22/02/22
/// https://worcesterbb.blackboard.com/ultra/courses/_43621_1/cl/outline
/// Code for the Command Class, based on Code made my Marc Price in OBJECT SESSION ???.
/// </summary>
namespace Server
{

    /// <summary>
    /// A Class used to control Commands that have no parameters, impliments ICommandZeroParam.
    /// </summary>
    public class Command : ICommandZeroParam
    {
        #region Variables

        //DECLARE a Action Delagate called _action, holds a reference to the Command that will be executed.
        private Action _action;

        #endregion

        #region Methods

        /// <summary>
        /// Method: Execute, executes the delagate found within _action.
        /// </summary>
        public void Execute()
        {
            //CALLS the _action Delegate.
            _action();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Property: Sets the Value of _action, to for a Command to be accessed and then executed.
        /// </summary>
        public Action SetAction 
        { 
            set 
            {
                //SETS the value of _action.
                _action = value;
            } 
        }

        #endregion
    }

    /// <summary>
    /// A Class used to control Commands that have one parameter, impliments ICommandOneParam. Has a generic of T to hold Parameters.
    /// </summary>
    public class Command<T> : ICommandOneParam<T>
    {
        #region Variables

        //DECLARE a Action Delagate called _action, holds a reference to the Command that will be executed. Has a generic of T which is used for the Parameter.
        private Action<T> _action;

        //DECLARE a Generic of type T called _data, used to hold the Parameter used by this Command.
        private T _data;

        #endregion

        #region Methods

        /// <summary>
        /// Method: Execute, executes the delagate found within _action.
        /// </summary>
        public void Execute()
        {
            //CALLS the _action Delegate with the Parameter found in _data.
            _action(_data);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Property: Sets the Value of _action, to for a Command to be accessed and then executed, Has a generic of T to hold Parameters.
        /// </summary>
        public Action<T> SetAction
        {
            set
            {
                //SETS the value of _action.
                _action = value;
            }
        }

        /// <summary>
        /// Property: Sets the Value of _data, which holds the parameter for this Command.
        /// </summary>
        public T SetData
        {
            set
            {
                //SETS the value of _data.
                _data = value;
            }
        }

        #endregion
    }
}
