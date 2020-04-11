//Grading ID: S6889
//Assignment: Program 4
//Due Date: 20 April 2020
//Section: CIS199-75
//Description: introduction program to classes and objects to calculate the shipping cost of a package

using System;
using static System.Console;

namespace Project4
{
    class GroundPackage
    {
        private int originZip,  //origin zip code
            destinationZip;  //destination zip code
        private double length,  //length in inches
               width,  //width in inches
               height,  //height in inches
               weight;  //weight in pounds
        public const int MIN = 0,  //constant for min validation
                         MAX = 99999,  //constant for max validation
                         DEFAULT_ORIGIN = 40204,  //constant for the default origin zip code
                         DEFAULT_DESTINATION = 60606;  //constant for the default destination zip code
        public const double DEFAULT_DIMENSIONS = 12.0;  //constant for the default length, width, height and weight

        //class constructor
        public GroundPackage(int orig, int dest, double l, double wid, double h, double wei)
        {
            OriginZip = orig;  //set OriginZip property to orig parameter
            DestinationZip = dest;  //set DestinationZip property to dest parameter
            Length = l;  //set Length property to l parameter
            Width = wid;  //set Width property to wid parameter
            Height = h;  //set Height property to h parameter
            Weight = wei;  //set Weight property to wei parameter
        }

        //OriginZip property
        public int OriginZip
        {
            get
            {
                return originZip;
            }

            set
            {
                //validate that origin zip is greater than min and less than max, otherwise set to default
                if (value <= MIN || value >= MAX)
                    originZip = DEFAULT_ORIGIN;
                else
                    originZip = value;
            }
        }

        //DestinationZip property
        public int DestinationZip
        {
            get
            {
                return destinationZip;
            }

            set
            {
                //validate that destination zip is greater than min and less than max, otherwise set to default
                if (value < MIN || value > MAX)
                    destinationZip = DEFAULT_DESTINATION;
                else
                    destinationZip = value;
            }
        }

        //Length property
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                //validate that length is greater than min, otherwise set to default
                if (value > MIN)
                    length = value;
                else
                    length = DEFAULT_DIMENSIONS;
            }
        }

        //Width property
        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                //validate that width is greater than min, otherwise set to default
                if (value > MIN)
                    width = value;
                else
                    width = DEFAULT_DIMENSIONS;
            }
        }

        //Height property
        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                //validate that height is greater than min, otherwise set to default
                if (value > MIN)
                    height = value;
                else
                    height = DEFAULT_DIMENSIONS;
            }
        }

        //Weight property
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                //validate that weight is greater than min, otherwise set to default
                if (value > MIN)
                    weight = value;
                else
                    weight = DEFAULT_DIMENSIONS;
            }
        }

        //ZoneDistance property to calculate the zone distance
        public int ZoneDistance
        {
            get
            {
                //calculate the zone distance
                return Math.Abs((originZip / 10000) - (destinationZip / 10000));
            }
        }

        //CalcCost method to calculate and return the shipping cost
        public double CalcCost()
        {
            const double SIZE_COST_FACTOR = .20,  //constant for the size multiplier
                         WEIGHT_COST_FACTOR = .35;  //constant for the weight multiplier
            double shippingCost;  //shipping cost variable

            //calculate the shipping cost
            shippingCost = (SIZE_COST_FACTOR * (Length + Width + Height)) + (WEIGHT_COST_FACTOR * ((ZoneDistance - 1) * Weight));

            //return the shipping cost
            return shippingCost;
        }

        //ToString method that builds and returns a string of all GroundPackage properties
        public override string ToString()
        {
            return $"Origin Zip Code: {OriginZip:d5}" +
                   $"{Environment.NewLine}Destination Zip Code: {DestinationZip:d5}" +
                   $"{Environment.NewLine}Length: {Length:f2} inches" +
                   $"{Environment.NewLine}Width: {Width:f2} inches" +
                   $"{Environment.NewLine}Height: {Height:f2} inches" +
                   $"{Environment.NewLine}Weight: {Weight:f2} pounds";
        }
    }

    class MainClass
    {
        //main method
        public static void Main(string[] args)
        {
            //create array of GroundPackage objects
            GroundPackage[] packageArray = new GroundPackage[6];

            //create and initialize GroundPackage objects and place them in the packageArray
            GroundPackage package1 = new GroundPackage(53456, 76434, 7.25, 7.25, 3.5, 4.25);
            packageArray[0] = package1;
            GroundPackage package2 = new GroundPackage(543456, -234, 16.0, 12.0, 2.0, 3.5);
            packageArray[1] = package2;
            GroundPackage package3 = new GroundPackage(65423, 96453, 3.75, 6.0, 1.0, .25);
            packageArray[2] = package3;
            GroundPackage package4 = new GroundPackage(00394, 73645, -7.34, 12.5, 4.0, 2.25);
            packageArray[3] = package4;
            GroundPackage package5 = new GroundPackage(47543, 87465, 12.5, 16.75, 12.5, 14.0);
            packageArray[4] = package5;
            GroundPackage package6 = new GroundPackage(25243, 07345, 22.0, 27.5, 14.5, 5.5);
            packageArray[5] = package6;

            //invoke the DisplayPackages method to display all of the properties of the GroundPackage objects
            WriteLine("Before Changes:");
            DisplayPackages(packageArray);

            //use object properties to change values of each of the objects
            package1.OriginZip = 40218;
            package1.DestinationZip = 90210;
            package1.Length = 5.25;
            package1.Width = 11.5;
            package1.Height = 2.5;
            package1.Weight = .75;

            package2.OriginZip = 10431;
            package2.DestinationZip = 84673;
            package2.Length = -5.0;
            package2.Width = 13.0;
            package2.Height = 3.25;
            package2.Weight = 1.5;

            package3.OriginZip = 456456;
            package3.DestinationZip = 35775;
            package3.Length = 18.0;
            package3.Width = -3.25;
            package3.Height = 12.75;
            package3.Weight = 5.5;

            package4.OriginZip = 00876;
            package4.DestinationZip = 73446;
            package4.Length = 11.5;
            package4.Width = 8.5;
            package4.Height = 1.25;
            package4.Weight = 3.75;

            package5.OriginZip = 63867;
            package5.DestinationZip = -34544;
            package5.Length = 7.75;
            package5.Width = 12.75;
            package5.Height = 4.5;
            package5.Weight = 8.0;

            package6.OriginZip = 91434;
            package6.DestinationZip = 54355;
            package6.Length = 8.25;
            package6.Width = 13.5;
            package6.Height = 7.5;
            package6.Weight = 9.75;

            //invoke the DisplayPackages method to display all of the newly changed properties of the GroundPackage objects
            WriteLine("After Changes:");
            DisplayPackages(packageArray);
        }

        //DisplayPackages method to display the objects using the ToString method created in the GroundPackage class
        public static void DisplayPackages(GroundPackage[] packageArray)
        {
            //loop through the packageArray array and display the properties of each object
            for (int x = 0; x < packageArray.Length; ++x)
            {
                //invoke the ToString method to display the properties of each object
                WriteLine(packageArray[x]);
                //display the shipping cost of each object
                WriteLine($"Cost: {packageArray[x].CalcCost():c}");
                WriteLine();
            }
        }
    }
}
