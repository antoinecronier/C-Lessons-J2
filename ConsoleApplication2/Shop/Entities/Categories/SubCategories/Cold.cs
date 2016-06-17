using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Shop
{
    public class Cold : Eatable
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value;
                this.OnPropertyChanged("MyProperty");
            }
        }
    }
}
