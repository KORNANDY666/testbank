using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11
{
    internal class testclass
    {
        int Age;
        string Name;
        public testclass(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        List<testclass2> tc2 = new List<testclass2>();
        


        public int age{ get => Age; set => Age = value; }
        public string name { get => Name; set => Name = value; }

        



        public void addUser()
        {
            Console.Write("Ange användarnamn : ");
            string input = Console.ReadLine().ToLower();
             var check = tc2.Find(i => i.name.Equals(input));
                if (check != null)
                {
                   Console.WriteLine("Grattis du är nu inloggad");

                }
                else
                {
                   Console.WriteLine("Jävlar vad fel du hade, testa igen");
                   
                }
                
         }


        
    }
}
