using System;
using System.Collections.Generic;
using System.Text;


namespace HW3
{
    
    public class Event
    {
        string name_event;
        string name_place;
        int guests_number;
        string client_name;
        string client_phone;
        DateTime date = new DateTime();
        static int counter = 1;
        int id = counter;
       public Event()
        {
           
        }

        public void Movie_event_days()
        {
            Console.WriteLine("How much days to add?");
            int d = int.Parse(Console.ReadLine());
            this.date = date.AddDays(d);
        }
        public void Movie_event_weeks()
        {
            Console.WriteLine("How much weeks to add?");
            int w = int.Parse(Console.ReadLine());
            this.date = date.AddDays(w*7);
        }
        public void AddEvent(ref Client client)
        {
            Console.WriteLine("Enter name event ");
            this.name_event=Console.ReadLine();
            Console.WriteLine("Enter place event ");
            this.name_place = Console.ReadLine();
            Console.WriteLine("Enter numbers of guests ");
            this.guests_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter date event in format dd.mm.yy");
            this.date = DateTime.Parse(Console.ReadLine());
            this.id = counter;
            this.client_name = client.name;
            this.client_phone = client.phone;
            counter++;
        }

        List<Event> events = new List<Event>();
        public override string ToString()
        {
            return $"\nName event: {name_event} \nPlace event: {name_place} \nNumber of guests: {guests_number} " +
                $"\nDate of event: {date.ToShortDateString()} \nId event: {id} \nClient name: {client_name} \nClient phone: {client_phone}";
        }

    }
}
