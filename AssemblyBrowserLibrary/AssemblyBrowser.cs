using System;
using System.Collections.Generic;
using System.Reflection;

namespace AssemblyBrowserLibrary
{
    public class AssemblyBrowser
    {
        private Assembly assembly { get; set; }

        public AssemblyBrowser(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public AssemblyData GetAssemblyData()
        {
            AssemblyData assemblyData = new AssemblyData(assembly.GetName().ToString());

            return assemblyData;
        }
    }
}
