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
            Console.WriteLine("Fido's all done");                   
            

            try
            {
                Thread.Sleep(10000);
            }

            catch (Exception ex) { }
            Console.WriteLine("\nBut he's stuck outside !");
            Console.WriteLine("\nFido barks to go inside");
            Console.WriteLine("\nGina grabs the remote control.");
            remote.PressButton();
            Console.WriteLine("\nFido's back inside !");
            remote.PressButton();
            





        }
    }
}
