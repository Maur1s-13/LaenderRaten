using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Interfaces
{
    public interface ISoundService
    {
        public void PlayAudioCorrect();

        public void MuteSound(bool mute);

        public void PlayAudioFail();
    }
}
