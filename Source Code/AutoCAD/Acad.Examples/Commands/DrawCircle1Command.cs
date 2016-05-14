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
    using Autodesk.AutoCAD.ApplicationServices;
    using Autodesk.AutoCAD.Colors;
    using Autodesk.AutoCAD.DatabaseServices;
    using Autodesk.AutoCAD.EditorInput;
    using Autodesk.AutoCAD.Geometry;
    using Autodesk.AutoCAD.GraphicsInterface;
    using Autodesk.AutoCAD.Internal;
    using Autodesk.AutoCAD.Runtime;
    using Autodesk.AutoCAD.Windows;

    using Kab.Acad.Core.Commands;

    using Utils = Kab.Acad.Core.Utils;

    internal class DrawCircle1Command : ButtonCommand, IAcadCommand
    {
        /// <summary>
        ///     Gets the command.
        /// </summary>
        /// <value>The command.</value>
        public string Command => "KABCIRCLE";

        /// <summary>
        ///     Gets the command description.
        /// </summary>
        /// <value>The description.</value>
        public string Description => "Creates a circle.";

        /// <summary>
        ///     Gets the command display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName => "Circle";

        /// <summary>
        ///     Gets the command long description.
        /// </summary>
        /// <value>The long description.</value>
        public string LongDescription => "For Example.";

        /// <summary>
        ///     Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        public override void Execute(object parameter)
        {
            Utils.WriteMessage("\nNot yet implemented.");
            Autodesk.AutoCAD.Internal.Utils.PostCommandPrompt();
        }
    }
}