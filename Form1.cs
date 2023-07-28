using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Workshop_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void horseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string horseName = horseNameInput.Text;
            int horseAge = Convert.ToInt32(horseAgeInput.Text) ;
            int horseHeight = Convert.ToInt32(horseHeightInput.Text);
          
            
            double[] times = new double[] { Convert.ToDouble(time1Input.Text),Convert.ToDouble(time2Input.Text), Convert.ToDouble(time3Input.Text) }


            Horse newHorse = new Horse(horseName, horseAge, horseHeight, times);

        }
    }
}
