using System;

/// <summary>
/// Author: Jack Hughes, James McQueen & Marc Price
/// Date: 22/02/22
/// https://worcesterbb.blackboard.com/ultra/courses/_43621_1/cl/outline
/// Code for the ICommand Interface, based on Code made my Marc Price in OBJECT SESSION ???.
/// </summary>
namespace Server
{
    /// <summary>
    /// An Interface used to Execute Commands.
    /// </summary>
    public interface ICommand
    {
        #region Methods

        /// <summary>
        /// Method: Execute, executes the delagate found within _action.
        /// </summary>
        void Execute();

        #endregion
    }

    /// <summary>
    ///  An Interface used to control Commands that have no parameters.
    /// </summary>
    public interface ICommandZeroParam : ICommand
    {
        #region Properties

        /// <summary>
        /// Property: Sets the Value of _action, to for a Command to be accessed and then executed.
        /// </summary>
        Action SetAction { set; }

        #endregion
    }

    /// <summary>
    ///  An Interface used to control Commands that have one parameter.
    /// </summary>
    public interface ICommandOneParam<T> : ICommand
    {
        #region Properties

        /// <summary>
        /// Property: Sets the Value of _data, which holds the parameter for this Command.
        /// </summary>
        T SetData { set; }

        /// <summary>
        /// Property: Sets the Value of _action, to for a Command to be accessed and then executed, Has a generic of T to hold Parameters.
        /// </summary>
        Action<T> SetAction { set; }

        #endregion
    }
}
