using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorium_TextAdventure.Rooms
{

    public class StartRoom : BaseState
    {
        public StartRoom(string roomName) : base(roomName)
        {
        }

        public override BaseState CheckConditions()
        {
        
            var input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.D)
            {
                Console.Clear();
                return new Room1("Room1");
            }
            return null;
        }

        public override void EnterState()
        {
            Console.WriteLine($"Du hast den {roomName} betreten");
        }

        public override void ExitState()
        {
            Console.WriteLine($"Du hast den {roomName} verlassen\n");
        }
    }
}
