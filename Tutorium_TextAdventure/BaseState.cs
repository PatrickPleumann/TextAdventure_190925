using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorium_TextAdventure
{
    public abstract class BaseState
    {
        public abstract void EnterState();
        public abstract void ExitState();
        public abstract BaseState CheckConditions();
    }
}
