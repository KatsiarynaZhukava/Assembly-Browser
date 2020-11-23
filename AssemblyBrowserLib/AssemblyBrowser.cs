using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace AssemblyBrowserLib
{
    class AssemblyBrowser
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
