using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougsDoor.Models
{
    internal class DogDoor
    {
        private bool _open;

        public DogDoor()
        {
            _open = false;
        }

        public void OpenDoor()
        {
            Console.WriteLine("The dog door Opens!");
            _open = true;
        }

        public void CloseDoor()
        {
            Console.WriteLine("The dog door closes !");
            _open = false;
        }
        public bool IsOpen()
        {
            return _open;
        }
    }
}
