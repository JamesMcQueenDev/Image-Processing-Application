using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jack Hughes
/// Date: 22/02/22
/// 
/// Code for the IUpdatable Interface.
/// </summary>
namespace Server
{
    /// <summary>
    /// An Interface for allowing a Class to Update.
    /// </summary>
    public interface IUpdatable
    {
        /// <summary>
        /// Method: Update, called every frame, by using pGameTime, used here to call ExecuteCommand.
        /// </summary>
        void Update();
    }
}
