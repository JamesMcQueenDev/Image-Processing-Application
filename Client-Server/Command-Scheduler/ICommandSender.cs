using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jack Hughes, James McQueen & Marc Price
/// Date: 22/02/22
/// https://worcesterbb.blackboard.com/ultra/courses/_43621_1/cl/outline
/// Code for the ICommandSender Interface, based on Code made my Marc Price in OBJECT SESSION ???.
/// </summary>
namespace Server
{
    /// <summary>
    /// An Interface used to provide a Class with the ability to schedule Commands.
    /// </summary>
    public interface ICommandSender
    {
        #region Properties

        /// <summary>
        /// Property: Gets and Sets the value of a local Variable called _scheduleCommand that all classes that impliment this Interface must have, 
        /// it holds the value of the next Command that the Implimentor wants to Execute.
        /// </summary>
        Action<ICommand> ScheduleCommand { get; set; }

        #endregion
    }
}
