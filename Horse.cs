using System;
using System.Linq;

namespace Practical_Workshop_1
{
    internal class Horse
    {
        private string name;
        private int age;
        private int height;
        private double[] times;

        public Horse(string name, int age, int height, double[] times)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.times = times;
         }

      
        public string horseDetails()
        {
            return $"Name: {name}\tAge: {age}\tHeight: {height}\tAverage run : {averageTime()} \n";
        }
        public double averageTime()
        {
           double  sum = 0;
          foreach(double i in times)
            {
                sum += i;

            }
            return sum / 3;
        }
 

    }
}
