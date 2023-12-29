using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTutorial
{
    internal class Person
    {
        //auto property
        public string FirstName { get; set; }


        /* Property
        public string FirstName
        {
            get { return FirstName; }
            set
            {
                FirstName = value;
                //UpdateUI(value)
            }
        }

        private string firstName;
        */
    }
}
