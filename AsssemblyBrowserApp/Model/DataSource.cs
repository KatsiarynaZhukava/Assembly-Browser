using AssemblyBrowserLibrary;
using System.Reflection;

namespace AsssemblyBrowserApp
{
    class DataSource
    {
        public AssemblyData GetAssembly(string assemblyPath)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            AssemblyBrowser assemblyBrowser = new AssemblyBrowser(assembly);
            return assemblyBrowser.GetAssemblyData();
        }
    }
}
