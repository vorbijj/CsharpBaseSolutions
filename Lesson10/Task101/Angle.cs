using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task101
{
    internal class Angle
    {
        int gradus;
        int minute;
        int second;
        readonly int direction;

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = Math.Abs(gradus);
            this.Minute = min;
            this.Second = sec;
            if (gradus >= 0)
            {
                this.direction = 1;
            }
            else
            {
                this.direction = -1;
            }
        }

        public int Gradus
        {
            get => gradus;
            set
            {
                if (value % 360 != 0)
                {
                    gradus = value % 360;
                }
                else if (value == 0)
                {
                    gradus = 0;
                }
                else
                {
                    gradus = 360;
                }
            }
        }
        public int Minute
        {
            get => minute;
            set
            {
                if (value / 60 != 0)
                {
                    Gradus += value / 60;
                }
                minute = value % 60;
            }
        }
        public int Second
        {
            get => second;
            set
            {
                if (value / 60 != 0)
                {
                    Minute += value / 60;
                }
                second = value % 60;
            }
        }

        public double ToRadians()
        {
            return ((Gradus + (Minute / 60.0) + (Second / 3600.0)) * Math.PI) / 180 * direction;
        }

        public override string ToString()
        {
            return $"{direction * gradus}°{minute}'{second}\"";
        }
    }
}
