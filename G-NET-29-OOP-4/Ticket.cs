using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_4
{

    public class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }
        public static decimal Tax { get; set; } = 0.14m;

        public decimal PriceAfterTax => Price + (Price * Tax);

        public Ticket(int id, string movie, decimal price)
        {
            TicketId = id;
            MovieName = movie;
            Price = price;
        }

        // Polymorphism: Virtual method to allow overriding
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        // Static Polymorphism: Method Overloading (Version 1)
        public void SetPrice(decimal newPrice)
        {
            Price = newPrice;
        }

        // Static Polymorphism: Method Overloading (Version 2)
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }
    }

}
