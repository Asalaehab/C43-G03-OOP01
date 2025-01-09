using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigntmentOOP
{
    internal struct Rectangle
    {

        #region Attributes
        private double width;
        private double height; 
        #endregion

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine(" Width cannot be negative.");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine(" Height cannot be negative.");
            }
        }

      
        public double Area
        {
            get { return width * height; }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }


    }
}
