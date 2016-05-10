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

namespace Kab.Acad.Examples.Commands
{
    using System;

    using Autodesk.AutoCAD.ApplicationServices;
    using Autodesk.AutoCAD.Internal;

    using Kab.Acad.Core.Commands;

    internal class DrawLine : ButtonCommand, IAcadCommand
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <value>The command.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public string Command => "KABLINE";

        /// <summary>
        /// Gets the command description.
        /// </summary>
        /// <value>The description.</value>
        public string Description => "Creates straight line segments";

        /// <summary>
        /// Gets the command display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName => "Line";

        /// <summary>
        /// Gets the command long description.
        /// </summary>
        /// <value>The long description.</value>
        public string LongDescription => $"With {this.DisplayName}, you can create a series of continuous line segments." + "\n" + 
                                         "Each segment is a line object that can be edited individually.";

        /// <summary>
        /// Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Execute(object parameter)
        {
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("\nNot yet implemented.");
            Utils.PostCommandPrompt();
        }
    }
}
