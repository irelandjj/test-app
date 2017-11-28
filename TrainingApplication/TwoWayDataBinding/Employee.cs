using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TwoWayDataBinding
{
    public class Employee 
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }

    }
}
