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

namespace Kab.Acad.Core.Extensions
{
    using System;

    using Autodesk.AutoCAD.ApplicationServices;
    using Autodesk.AutoCAD.Colors;
    using Autodesk.AutoCAD.DatabaseServices;
    using Autodesk.AutoCAD.EditorInput;
    using Autodesk.AutoCAD.Geometry;
    using Autodesk.AutoCAD.GraphicsInterface;
    using Autodesk.AutoCAD.Internal;
    using Autodesk.AutoCAD.Runtime;
    using Autodesk.AutoCAD.Windows;

    using CadRx = Autodesk.AutoCAD.Runtime;
    using Utils = Kab.Acad.Core.Utils;

    public static class EntityExtensions
    {
        #region Private Methods

        /// <summary>
        /// Adds to space.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="btrId">The BTR identifier.</param>
        /// <returns><c>true</c> if successfully added, <c>false</c> otherwise.</returns>
        /// <exception cref="System.ArgumentNullException">You cannot add a null entity to the database!</exception>
        private static bool AddToBlockTableRecord(Entity entity, ObjectId btrId)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "You cannot add a null entity to the database!");
            }

            bool success;
            using (OpenCloseTransaction tr = Utils.StartNewOpenCloseTransaction)
            {
                try
                {
                    BlockTableRecord btr = (BlockTableRecord)tr.GetObject(btrId, OpenMode.ForWrite);
                    btr.AppendEntity(entity);
                    tr.AddNewlyCreatedDBObject(entity, true);
                    tr.Commit();
                    success = true;
                }
                catch (CadRx.Exception)
                {
                    success = false;
                }
            }
            return success;
        }

        #endregion Private Methods

        #region Public Methods

        /// <summary>
        ///     Adds the entity to the modelspace of the active document.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><c>true</c> if successfully added, <c>false</c> otherwise.</returns>
        public static bool AddToModelSpace(this Entity entity)
        {
            return AddToBlockTableRecord(entity, SymbolUtilityServices.GetBlockModelSpaceId(Utils.Db));
        }

        /// <summary>
        ///     Adds the entity to the modelspace of the document of the supplied database.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="db">The database to add the entity to.</param>
        /// <returns><c>true</c> if successfully added, <c>false</c> otherwise.</returns>
        public static bool AddToModelSpace(this Entity entity, Database db)
        {
            return AddToBlockTableRecord(entity, SymbolUtilityServices.GetBlockModelSpaceId(db));
        }

        #endregion Public Methods
    }
}