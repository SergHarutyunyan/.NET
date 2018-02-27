using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewTroelsen.Has_a_Relationship
{
    class Music
    {
        private Radio radio;

        public Music()
        {
            radio = new Radio();
        }

        public void TurnRadioOn()
        {
            radio.Play();
        }
    }
}
