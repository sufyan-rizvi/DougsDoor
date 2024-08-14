using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace DougsDoor.Models
{
    internal class Remote
    {
        private DogDoor _door;
      

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing remote control button !");
            if (_door.IsOpen())
                _door.CloseDoor();

            else
            {
                _door.OpenDoor();
                var timer = new System.Timers.Timer(5000);

                // Event handler for the timer's elapsed event
                timer.Elapsed += (sender, e) =>
                {
                    _door.CloseDoor(); // Assuming a 'Close' method exists
                    timer.Stop(); // Stop the timer after closing the door
                };

                // Start the timer
                timer.Start();

            }
        }


    }
}
