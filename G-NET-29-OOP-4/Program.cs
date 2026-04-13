using System;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_29_OOP_4
{

    // Part 01 :
    #region Q1 :
    //*Static Binding(Compile Time):
    //    Method overloading
    //    Method hiding(new keyword)
    //    Static methods
    //    Private methods
    //* Dynamic Binding(Runtime):
    //    Virtual methods
    //    Method overriding
    //    Interface calls
    #endregion

    #region Q2 :
    //* Method Overriding(Dynamic):
    //    Inheritance between child and parent.
    //    must same params.
    //    Change "behavior" of a method inherited from parent.
    //* Method Overloading(Static):
    //    within same class.
    //    must diff params.
    //    Performing same tasks with different data.
    #endregion

    #region Q3:
    //** The runtime checks the actual object in memory to decide which method to call 
    //     this is what makes polymorphism work.
    // * virtual:

    // Written at Base Class.
    //    it say to compiler decide later any version will use.
    // * override:
    //  Written at Derived Class.
    //    Alternate behavior for method

    #endregion

    #region Part 02 :

    #endregion


    class Program
    {
        static void Main()
        {
            Cinema myCinema = new Cinema(10);
            myCinema.OpenCinema();

            StandardTicket t1 = new StandardTicket(1, "Inception", 100, "A-5");
            VIPTicket t2 = new VIPTicket(2, "Avengers", 200, true, 50);
            IMAXTicket t3 = new IMAXTicket(3, "Dune", 180, false);

            // Testing Overloading
            Console.WriteLine("\n========== SetPrice Test ==========");
            t1.SetPrice(150m);
            Console.WriteLine($"Setting price directly: {t1.Price}");

            t1.SetPrice(100m, 1.5m);
            Console.WriteLine($"Setting price with multiplier: 100 x 1.5 = {t1.Price}");

            myCinema.AddTicket(t1);
            myCinema.AddTicket(t2);
            myCinema.AddTicket(t3);

            // Testing Dynamic Polymorphism
            myCinema.PrintAllTickets();

            // Testing ProcessTicket
            Cinema.ProcessTicket(t2);

            myCinema.CloseCinema();
        }
    }
}
