//  AutoCAD .NET Samples
//
//  Copyright(c) 2016 Keith Brown
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.

// AutoCAD queries the application's assembly for one or more CommandClass attributes. 
// If instances of this attribute are found, AutoCAD searches only their associated types 
// for command methods. Otherwise, it searches all exported types.

namespace Kab.Acad.Core.Commands
{
    using System;
    using System.Windows.Input;

    using Autodesk.AutoCAD.ApplicationServices;
    using Autodesk.AutoCAD.Internal;

    /// <summary>
    /// Class ButtonCommand.
    /// </summary>
    public abstract class ButtonCommand : ICommand
    {
        #region Public Events

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion Public Events

        #region Public Methods

        /// <summary>
        /// Determines whether this instance can execute the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns><c>true</c> if this instance can execute the specified parameter; otherwise, <c>false</c>.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        public abstract void Execute(object parameter);

        #endregion Public Methods

        #region Protected Methods

        /// <summary>
        ///
        /// </summary>
        protected void CancelCommands()
        {
            if ((short)Application.GetSystemVariable("CMDACTIVE") != 0)
            {
                Application.DocumentManager.MdiActiveDocument.SendStringToExecute("\u001b\u001b", false, true, false);
                Utils.PostCommandPrompt();
            }
        }

        /// <summary>
        /// Executes the button command at the command line.
        /// </summary>
        /// <param name="command">The command.</param>
        protected void ExecuteCommand(string command)
        {
            Application.DocumentManager.MdiActiveDocument.SendStringToExecute(command + "\n", true, false, true);
        }

        #endregion Protected Methods
    }
}