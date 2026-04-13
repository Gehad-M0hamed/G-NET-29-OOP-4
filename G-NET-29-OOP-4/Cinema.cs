using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_4
{
    public class Cinema
    {
        private Ticket[] tickets;
        private int ticketCount;

        public Cinema(int capacity)
        {
            tickets = new Ticket[capacity];
            ticketCount = 0;
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Console.WriteLine("Projector started.");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            Console.WriteLine("Projector stopped.");
        }

        public void AddTicket(Ticket t)
        {
            if (ticketCount < tickets.Length)
            {
                tickets[ticketCount++] = t;
            }
        }

        // Dynamic Binding in action
        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");
            for (int i = 0; i < ticketCount; i++)
            {
                tickets[i].PrintTicket();
            }
        }

        // Static method processing any type of Ticket (Polymorphism)
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }
    }
}
