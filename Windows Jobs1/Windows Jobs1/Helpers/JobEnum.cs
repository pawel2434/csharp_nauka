using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zetalex.Windows_Jobs1.Helpers
{
    public enum JobEnum
    {
        [JobState(interval: 1)]
        TestJob = 1,
    }
}
