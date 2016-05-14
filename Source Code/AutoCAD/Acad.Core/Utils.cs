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

namespace Kab.Acad.Core
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

    using CadAp = Autodesk.AutoCAD.ApplicationServices;
    using CadClr = Autodesk.AutoCAD.Colors;
    using CadDb = Autodesk.AutoCAD.DatabaseServices;
    using CadEd = Autodesk.AutoCAD.EditorInput;
    using CadGe = Autodesk.AutoCAD.Geometry;
    using CadGi = Autodesk.AutoCAD.GraphicsInterface;
    using CadRx = Autodesk.AutoCAD.Runtime;
    using CadWnd = Autodesk.AutoCAD.Windows;

    using CadApplication = Autodesk.AutoCAD.ApplicationServices.Application;

    /// <summary>
    /// Class Utils.
    /// </summary>
    public static class Utils
    {
        #region Public Properties

        /// <summary>
        /// Gets the Database object from the active Document.
        /// </summary>
        /// <value>The database.</value>
        public static Database Db => Doc.Database;

        /// <summary>
        /// Gets the active Document object.
        /// </summary>
        /// <value>The document.</value>
        public static Document Doc => CadApplication.DocumentManager.MdiActiveDocument;

        /// <summary>
        /// Gets the active Document Editor object.
        /// </summary>
        /// <value>The editor.</value>
        public static Editor Ed => Doc.Editor;

        /// <summary>
        /// Gets the working database.
        /// </summary>
        /// <value>The working database.</value>
        public static Database WorkingDb => HostApplicationServices.WorkingDatabase;

        /// <summary>
        /// Starts a new openclose transaction from the WorkingDatabase.
        /// </summary>
        /// <value>The start new open close transaction.</value>
        public static OpenCloseTransaction StartNewOpenCloseTransaction => TransMan.StartOpenCloseTransaction();

        /// <summary>
        /// Starts a new transaction in the WorkingDatabase.
        /// </summary>
        /// <value>The start new transaction.</value>
        public static Transaction StartNewTransaction => TransMan.StartTransaction();

        /// <summary>
        /// Gets the Transaction Manager from the active document.
        /// </summary>
        /// <value>The trans man.</value>
        public static CadDb.TransactionManager TransMan => WorkingDb.TransactionManager;

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Sends a string to the command line in the active Editor
        /// </summary>
        /// <param name="message">The message to send.</param>
        public static void WriteMessage(string message)
        {
            Ed.WriteMessage(message);
        }

        /// <summary>
        /// Sends a string to the command line in the active Editor using String.Format.
        /// </summary>
        /// <param name="message">The message containing format specifications.</param>
        /// <param name="parameter">The variables to substitute into the format string.</param>
        public static void WriteMessage(string message, params object[] parameter)
        {
            Ed.WriteMessage(message, parameter);
        }

        #endregion Public Methods
    }
}
