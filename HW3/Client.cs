using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    public class Client
    {
        public string name;
        public string phone;
        public Client(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public Client()
        {
        }

        public void AddClient()
        {
            Client client1 = new Client();
            Console.WriteLine("Enter client name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter client phone in format 380981111111");
            string phone1 = Console.ReadLine();
            int n = 0;
            for (int i = 0; i < phone1.Length; i++)
            {

                if (Char.IsDigit(phone1[i]))
                {
                    continue;
                }
                else
                {
                    n++;
                }
            }
            if (phone1.Length != 12 || n != 0)
            {
                Console.WriteLine("Wrong phone format");
            }
            else
            {
                this.name = name;
                this.phone = phone1;
            }
        }

        public override string ToString()
        {
            return $"\nName: {name} \nPhone: {phone}";
        }

    }
  
}
