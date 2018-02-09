using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    //Person расширяет Object
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }

        public Person(string fName,string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public Person() { }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}, SSN: {3}]", FirstName, LastName, Age, SSN);
            return myState;
        }
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
            /*
            if (obj is Person && obj !=null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            */
        }
        //Вернуть хэш-код на основе уникальных строковых данных
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}
