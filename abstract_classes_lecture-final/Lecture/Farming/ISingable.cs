using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    interface ISingable
    {
        string Name { get; }
        string Sound { get; }
        string MakeSoundOnce();
        string MakeSoundTwice();
    }
}
