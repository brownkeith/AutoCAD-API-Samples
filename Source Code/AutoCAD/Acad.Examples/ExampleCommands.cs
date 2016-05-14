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

[assembly: Autodesk.AutoCAD.Runtime.CommandClass(typeof(Kab.Acad.Examples.ExampleCommands))]

namespace Kab.Acad.Examples
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

    using Kab.Acad.Examples.Commands;

    public class ExampleCommands
    {
        [CommandMethod("KABLINE1")]
        public void DrawLine1Command()
        {
            DrawLine1Command lineCommand = new DrawLine1Command();
            lineCommand.Execute();
        }

        [CommandMethod("KABCIRCLE")]
        public void DrawCircle1Command()
        {
            DrawCircle1Command circleCommand = new DrawCircle1Command();
            circleCommand.Execute();
        }
    }
}
