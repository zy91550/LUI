﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lasercom.objects
{
    /// <summary>
    /// Base class for instrument-specific abstract classes.
    /// </summary>
    public abstract class LuiObject : ILuiObject
    {
        abstract protected void Dispose(bool disposing);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public static ILuiObject Create<P>(LuiObjectParameters<P> p) where P:LuiObjectParameters<P>
        {
            return (ILuiObject)Activator.CreateInstance(p.Type, p.ConstructorArray);
        }

        public static ILuiObject Create(LuiObjectParameters p)
        {
            return (ILuiObject)Activator.CreateInstance(p.Type, p.ConstructorArray);
        }

        public static ILuiObject Create(LuiObjectParameters p, IEnumerable<ILuiObject> dependencies)
        {
            IEnumerable<object> args = p.ConstructorArray.AsEnumerable().Concat(dependencies);
            return (ILuiObject)Activator.CreateInstance(p.Type, args);
        }
    }
}
