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
        July july = new July();

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
            int horseAge = int.Parse(horseAgeInput.Text);
            int horseHeight = int.Parse(horseHeightInput.Text);


            double[] times = new double[] { double.Parse(time1Input.Text), double.Parse(time2Input.Text), double.Parse(time3Input.Text) };


            Horse newHorse = new Horse(horseName, horseAge, horseHeight, times);
            july.addHorse(newHorse);
            july.displayRoster(RosterDisplay);

           




        }

        private void RosterDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void predictButton_Click(object sender, EventArgs e)
        {
        
            string information = july.favourite().horseDetails();


          
            if (sender is Button)
            {
                Button button = (Button)sender;
                if (button.Tag != null)
                {
                    information = button.Tag.ToString();
                }
            }

            Form popupForm = new Form();
            popupForm.Size = new Size(200, 500); 

            int labelY = 20; 
            Label lblTitle = new Label();
            lblTitle.Text = "The next winner might probably be:";
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, labelY); 

            labelY += lblTitle.Height + 10; 

            Label lblInfo = new Label();
            lblInfo.Text = information;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(20, labelY); 
            popupForm.Size = new Size(200, lblInfo.Bottom + 50);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(20, 80);
            btnOK.Click += (s, args) =>
            {
              
                popupForm.Close();
            };
          
            popupForm.Controls.Add(lblTitle);
            popupForm.Controls.Add(lblInfo);

            popupForm.ShowDialog();
        }
    }
    }

