using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Workshop_1
{
    internal class July
    {
        List<Horse> horses = new List<Horse>();

        public void addHorse(Horse horse)
        {
            horses.Add(horse);
        }
        public void displayRoster(TextBox textBox)
        {
            foreach(Horse horse in horses)
            {
                textBox.Text = horse.horseDetails();
            }
        }
        public Horse favourite()
        {
            double maxAverageTime = double.MinValue;
            Horse horseWithMaxAvgTime = null;


            foreach (Horse horse in horses)
            {
                if (horse.averageTime() > maxAverageTime)
                {
                    maxAverageTime = horse.averageTime();
                    horseWithMaxAvgTime = horse;
                }
            }
            return horseWithMaxAvgTime;
        }
    }
}
