using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
