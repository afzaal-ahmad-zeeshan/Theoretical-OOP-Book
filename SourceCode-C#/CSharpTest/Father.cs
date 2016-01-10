using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Father
    {
        public string Name { get; set; }
        public string Graduation { get; set; }

        // Functions
        public void Sleep() { }
        public void Eat() { }
    }

    class Son
    {
        public string Name { get; set; }
        public string Graduation { get; set; }

        // Functions
        public void Sleep() { }
        public void Eat() { }

        public string Job { get; set; }
        public int BikingHours { get; set; }

        public void GoToWork() { }
    }

    class Daughter
    {
        public string Name { get; set; }
        public string Graduation { get; set; }

        // Functions
        public void Sleep() { }
        public void Eat() { }

        public string Interest { get; set; }
        public int StudyHours { get; set; }

        public void MaintainSystem() { }
    }
}
