using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                Thread.Sleep(5000);
                _door.CloseDoor();

            }
        }


    }
}
