using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person p1 = new Person();
            p1.FirstName = "Frank";
            p1.LastName = "Hank";
            p1.Age = 20;
            p1.SSN = "123";

            Person p = new Person();
            p.FirstName = "Frank";
            p.LastName = "Hank";
            p.Age = 20;
            p.SSN = "123";

          

            //Исп. унаследованные члены System.Object
            Console.WriteLine("ToString: {0}",p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            //Создать другую ссылку на p1
            Person p2 = p1;
            object o = p2;
            
            //Указывают ли ссылки на один и тот же объект памяти
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }



            Console.WriteLine("Два разных объекта p1 и р с одинаковыми значениями");
            //Console.WriteLine("Два разных объекта p1 и р с одинаковыми значениями", object.Equals(p1,p));
            if (p1 == p)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Два объекта ссылаются на 1 ссылку");
            //Console.WriteLine("", object.ReferenceEquals(p1,p2));
            if (p1 == p2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            Console.ReadLine();
        }
    }
}
