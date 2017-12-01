using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ag = rnd.Next(1, 4);
            Agent agent = new Agent(ag);
            
            Elevator elevator = new Elevator();
            List<Floor> lfloor = new List<Floor>();

            Floor f1 = new Floor(1, elevator);
            Floor f2 = new Floor(2, elevator);
            Floor f3 = new Floor(3, elevator);
            Floor f4 = new Floor(4, elevator);
            
            Agent a1 = new Agent(1);
            Agent a2 = new Agent(2);
            Agent a3 = new Agent(3);
            Agent a4 = new Agent(4);

            lfloor.Add(f1);
            lfloor.Add(f2);
            lfloor.Add(f3);
            lfloor.Add(f4);

            elevator._floorAll = lfloor;
            // Set the current floor 
            elevator._floorCurrent = f1;
            //2 Building call ladder   Want to go downstairs 
            f2.CommandDown();
            // Target floor is 1 floor 
            elevator.CommandStop(f1);
            //4 Building call ladder 
            f4.CommandUp();
            // Target floor is 4 floor 
            elevator.CommandStop(f4);

            Console.ReadLine();
        }
    }
}
