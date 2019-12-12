using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public class ConvAttribute : Attribute
    {
        public ConvAttribute() { }
        public ConvAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
    
}
