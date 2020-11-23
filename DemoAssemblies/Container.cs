using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssemblies
{
    public class Container
    {
        private bool isEmpty;

        public Container(bool isEmpty)
        {
            this.isEmpty = isEmpty;
        }

        public bool IsEmpty { get; set; }
    }
}
