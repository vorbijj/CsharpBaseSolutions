using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task151
{
    internal interface IProgression : ISeries
    {
        string NameProgression { get; }
        int Step { get; set; }
        int StartValue { get; }
    }
}
