using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.BTPhone;
using T2203E_CSharp.session1;


namespace T2203E_CSharp
{
    internal class Program
    {
        static void Main(string[] args, PhoneBook phoneBook)
        {
            phoneBook.InsertPhone("John", "123-456-7890");
            phoneBook.InsertPhone("John", "098-765-4321");
            phoneBook.InsertPhone("Jane", "111-222-3333");

            phoneBook.SearchPhone("John");
            // Output: Phone number(s) for John: 123-456-7890, 098-765-4321

            phoneBook.SearchPhone("Jane");
            // Output: Phone number(s) for Jane: 111-222-3333

            phoneBook.SearchPhone("Alice");
            // Output: No phone number(s) found for Alice.

            phoneBook.UpdatePhone("Jane", "444-555-6666");

            phoneBook.SearchPhone("Jane");
            // Output: Phone number(s) for Jane: 444-555-6666

            phoneBook.Sort();

            // PhoneList is now sorted by name
        }


        static void Main1(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                throw new Exception("Y bằng 0 Mất rồi");
                y++;
                float z = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }

        static void Main2(string[] args)
        {
            Human h = new Human();
            h.Run();
            h.Age = 19;
            h.Email = "abc@gmail.com";
            Console.WriteLine(h.Age);

            Student s = new Student();
            // s.telephone[0] = "0123345664";
            s[0] = "02335656563";

            List<string> ls = new List<string>();
            ls.Add("hello");
            ls.Add("world");
            ls.Add("morning");

            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }

            foreach (string l in ls)
            {
                Console.WriteLine(l);
            }
        }


    }
}
