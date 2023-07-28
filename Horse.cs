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
            times = new double[3];
         }

      
        public string horseDetails()
        {
            return $"Name: {name}\tAge: {age}\tHeight: {height}\tAverage run : {averageTime()}";
        }
        public double averageTime()
        {
            return times.Average();
        }
 

    }
}
