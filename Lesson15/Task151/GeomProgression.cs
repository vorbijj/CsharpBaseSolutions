using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task151
{
    internal class GeomProgression : IProgression
    {
        static readonly string NAME_PROGRESSION = "<Геометрическая прогрессия>";

        int step;
        int startValue;
        int currentValue;

        public string NameProgression => NAME_PROGRESSION;
        public int Step { get => step; set => step = value; }
        public int StartValue { get => startValue; }

        public int GetNext()
        {
            return currentValue *= step;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}
