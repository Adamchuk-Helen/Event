using System;

namespace HW3
{  
    class Program
    {

        static void Menu(ref Client client1, ref Event event1)
        {
            do
            {
               
                Console.WriteLine("\n\n1. Add Client");
                Console.WriteLine("2. Show Client information");
                Console.WriteLine("3. Add Event");
                Console.WriteLine("4. Show Event information");
                Console.WriteLine("5. Movie Event to some days");
                Console.WriteLine("6. Movie Event to some weeks");
                Console.WriteLine("0. Exit");
                uint ch = uint.Parse(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        {
                            client1.AddClient();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(client1.ToString());
                            break;
                        }
                    case 3:
                        {
                            event1.AddEvent(ref client1);
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine(event1.ToString());
                            break;
                        }
                    case 5:
                        {

                            event1.Movie_event_days();
                            break;
                        }
                    case 6:
                        {

                            event1.Movie_event_weeks();
                            break;
                        }
                }
            }
            while (true);

        
    }

        static void Main(string[] args)
        {
            Client client1 = new Client();
            Event event1 = new Event();
            Menu(ref client1, ref event1);

        }
           
    }
}
