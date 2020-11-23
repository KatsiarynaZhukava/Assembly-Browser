using System.Collections.Generic;

namespace AssemblyBrowserLibrary
{
    public class NamespaceData
    {
        public string Name { get; set; }
        public List<TypeData> Types { get; set; } = new List<TypeData>();

        public NamespaceData(string name)
        {
            this.Name = name;
        }
    }
}
