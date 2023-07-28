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
        private HashSet<Horse> displayedHorses = new HashSet<Horse>();

        public void addHorse(Horse horse)
        {
            horses.Add(horse);
        }
        public void displayRoster(TextBox textBox)
        {


            foreach (Horse horse in horses)
            {
                if (!displayedHorses.Contains(horse))
                {
                    textBox.AppendText(Environment.NewLine);
                    textBox.AppendText(horse.horseDetails() + "\n");
                    displayedHorses.Add(horse);
                }
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
