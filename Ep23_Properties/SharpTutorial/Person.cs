using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTutorial
{
    internal class Person
    {
        public Person(string first, string last) 
        {
            FirstName = first;
            LastName = last;
        }

        //auto property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        

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
