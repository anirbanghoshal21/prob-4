using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prob_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300
                };

            arList.Remove(null); 
            arList.RemoveAt(4); 
            arList.RemoveRange(0, 2);

            foreach (var item in arList)
            Console.WriteLine(item);
            Console.ReadLine(); 
        }

        

        }
    }

