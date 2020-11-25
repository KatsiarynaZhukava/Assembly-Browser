using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;

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
            List<Type> assemblyTypes = assembly.GetTypes().ToList<Type>();
            BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;

            foreach (Type type in assemblyTypes)
            {
                TypeData typeData = new TypeData(type.GetTypeInfo());

                NamespaceData namespaceData = new NamespaceData(type.Namespace);

                if (!assemblyData.Namespaces.Any(nspace => nspace.Name == type.Namespace))
                {
                    assemblyData.Namespaces.Add(namespaceData);
                }
                else
                {
                    namespaceData = assemblyData.Namespaces.First(nspace => nspace.Name == type.Namespace);
                }

                foreach (FieldInfo fieldInfo in type.GetFields(bindingFlags))
                {
                    typeData.Fields.Add(fieldInfo);
                }
                foreach (PropertyInfo propertyInfo in type.GetProperties(bindingFlags))
                {
                    typeData.Properties.Add(propertyInfo);
                }
                foreach (MethodInfo methodInfo in type.GetMethods(bindingFlags))
                {
                    typeData.Methods.Add(methodInfo);
                }
                namespaceData.Types.Add(typeData);
            }
            return assemblyData;
        }
    }
}
