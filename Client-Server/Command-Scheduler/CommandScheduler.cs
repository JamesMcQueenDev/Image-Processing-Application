using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jack Hughes, James McQueen & Marc Price
/// Date: 22/02/22
/// https://worcesterbb.blackboard.com/ultra/courses/_43621_1/cl/outline
/// Code for the CommandScheduler Class, based on Code made my Marc Price in OBJECT SESSION ???.
/// </summary>
namespace Server
{
    /// <summary>
    /// A Class used to schedule Commands, impliments ICommandScheduler, IUpdatable and IService.
    /// </summary>
    public class CommandScheduler : ICommandScheduler, IUpdatable, IService
    {
        #region Variables

        //DECLARE an IList called _commandList that will hold a reference to all of the Scheduled ICommands in the Engine, allowing them to be called in sequence.
        private IList<ICommand> _commandList;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor: For the CommandScheduler  Class.
        /// </summary>
        public CommandScheduler()
        {
            //INSTANSIATES the _commandList IList as a new List, holds ICommands.
            _commandList = new List<ICommand>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method: ExecuteCommand, calls the Execute Method on the Command that has been passed into it via a Parameter.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be executed next.</param>
        public void ExecuteCommand(ICommand pCommand)
        {
            //CALLS the Execute Method on the pCommand Parameter.
            pCommand.Execute();
        }

        /// <summary>
        /// Method: ScheduleCommand, adds the Command that has been passed into it via a Parameter to the _commandList.
        /// </summary>
        /// <param name="pCommand">The Command that needs to be added to the _commandList.</param>
        public void ScheduleCommand(ICommand pCommand)
        {
            //ADDS the pCommand to the _commandList.
            _commandList.Add(pCommand);
        }

        /// <summary>
        /// Method: Update, called every frame, by using pGameTime, used here to call ExecuteCommand.
        /// </summary>
        /// <param name="pGameTime">Provides a snapshot of timing values.</param>
        public void Update()
        {
            // FOR everything in _commandList.
            foreach (ICommand c in _commandList)
            {
                //CALL ExecuteCommand on the next Command in _commandList.
                ExecuteCommand(c);
            }
        }

        #endregion
    }
}
