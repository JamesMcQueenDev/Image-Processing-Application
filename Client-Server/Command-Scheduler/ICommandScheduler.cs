using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jack Hughes, James McQueen & Marc Price
/// Date: 22/02/22
/// https://worcesterbb.blackboard.com/ultra/courses/_43621_1/cl/outline
/// Code for the ICommandScheduler Interface, based on Code made my Marc Price in OBJECT SESSION ???.
/// </summary>
namespace Server
{
    /// <summary>
    /// An Interface used to schedule Commands.
    /// </summary>
    public interface ICommandScheduler
    {
        #region Methods

        /// <summary>
        /// Method: ExecuteCommand, calls the Execute Method on the Command that has been passed into it via a Parameter.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be executed next.</param>
        void ExecuteCommand(ICommand pCommand);

        /// <summary>
        /// Method: ScheduleCommand, adds the Command that has been passed into it via a Parameter to the _commandList.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be added to the _commandList.</param>
        void ScheduleCommand(ICommand pCommand);

        #endregion
    }
}
