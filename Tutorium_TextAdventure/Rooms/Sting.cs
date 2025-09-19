using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorium_TextAdventure.Rooms
{
    internal class Sting : BaseState
    {
        Names room = new Names();
        Random rnd = new Random();

        public Sting(string roomName) : base(roomName)
        {
        }

        public override BaseState CheckConditions()
        {
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.W)
            {
                return new Return1($"{room.prefix[rnd.Next(0, room.prefix.Count)] + room.names + room.suffix[rnd.Next(0, room.suffix.Count)]}");
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
