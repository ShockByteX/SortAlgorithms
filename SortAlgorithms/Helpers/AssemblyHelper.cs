﻿using System;
using System.Linq;
using System.Reflection;

namespace SortAlgorithms.Helpers
{
    public static class AssemblyHelper
    {
        public static Type[] GetTypes(Assembly assembly, string strNamespace)
        {
            return (from type in assembly.GetTypes() where type.Namespace == strNamespace select type).ToArray();
        }
    }
}
