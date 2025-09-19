using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorium_TextAdventure.Rooms;

namespace Tutorium_TextAdventure
{
    public class FSM
    {

        public ConsoleKeyInfo _key = new ConsoleKeyInfo();
        public BaseState _startRoom = new StartRoom("Startraum");
        public BaseState _currentState;


        public void Init()
        {
            _startRoom.EnterState();
            _currentState = _startRoom;

            while (true)
            {
                var newState = _currentState.CheckConditions();

                if (newState != null)
                {
                    _currentState.ExitState();
                    newState.EnterState();
                    _currentState = newState;
                }

            }
        }
    }
}
