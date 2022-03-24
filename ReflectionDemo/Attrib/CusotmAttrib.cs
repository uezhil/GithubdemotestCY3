using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrib
{
    [AttributeUsage(AttributeTargets.Method,Inherited =false)]
    class CusotmAttrib:Attribute
    {
        public string CustomInfo { get; set; }
    }
}
