using System.Collections.Generic;
using System.Reflection;

namespace AssemblyBrowserLib
{
    class TypeData
    {
        public TypeInfo TypeInfo { get; private set; }
        public List<MethodInfo> Methods { get; private set; } = new List<MethodInfo>();
        public List<PropertyInfo> Properties { get; private set; } = new List<PropertyInfo>();
        public List<FieldInfo> Fields { get; private set; } = new List<FieldInfo>();

        public TypeData(TypeInfo typeInfo)
        {
            this.TypeInfo = typeInfo;
        }
    }
}
