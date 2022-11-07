using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4_11
{
    internal class jaja
    {

        public int Age { get; set; }
        public string Name { get; set; }

        List<jaja> fotboll = new List<jaja>(5);

        public string add()
        {
            Console.WriteLine("vill du hoppa");
            for (int i = 0; i < fotboll.Count; i++)
            {
                Console.Write("Ange ålder : ");
                Console.WriteLine("Ange Namn : ");
                fotboll.Add(fotboll[i]);
            }

            foreach (var item in fotboll)
            {
                Console.WriteLine(item.Name + item.Age);
            }
            return Name;
        
        }

    }
}
