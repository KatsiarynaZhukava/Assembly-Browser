using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    class AssemblyData
    {
        public string AssemblyName { get; set; }
        public List<NamespaceData> Namespaces { get; set; } = new List<NamespaceData>();

        public AssemblyData(string assemblyName)
        {
            this.AssemblyName = assemblyName;
        }
    }
}
