using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorium_TextAdventure.Rooms
{
    internal class thinking : BaseState
    {
        public thinking(string roomName) : base(roomName)
        {
        }

        public override BaseState CheckConditions()
        {
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.W)
            {
                return null;
            }
            return null;
        }

        public override void EnterState()
        {
            Console.WriteLine($"Du hast den {roomName} betreten");
        }

        public override void ExitState()
        {
            Console.WriteLine($"Du hast den {roomName} verlassen");
        }
    }
}
