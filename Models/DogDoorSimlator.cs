using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DougsDoor.Models
{
    internal class DogDoorSimlator
    {
        public static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            
            



            Console.WriteLine("Fido barks to go outside");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside");

            //remote.PressButton();
            Console.WriteLine("Fido's all done");
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Fido's stuck outside");
                Console.WriteLine("Fido starts barking");
                Console.WriteLine("Gina grabs remote");
                remote.PressButton();
                Console.WriteLine("Fido's back inside");
            }

            //remote.PressButton();
            


        }
    }
}
