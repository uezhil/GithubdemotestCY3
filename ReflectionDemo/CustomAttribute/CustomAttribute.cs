using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    class CustomAttribute:Attribute
    {
        public string CustomMetaInfo { get; set; }

    }
}
