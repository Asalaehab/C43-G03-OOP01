namespace AssigntmentOOP
{
    internal class Program
    {
        static double cal_distance(Point p1, Point p2)
        {
            // Calculate the Euclidean distance
            double dist = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            return dist;
        }
        static void Main(string[] args)
        {
            #region Q1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
            //foreach (string i in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region Q2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] arr = new Person[3];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new Person();
            //    Console.Write("Enter Name : ");
            //    arr[i].Name = Console.ReadLine();
            //    Console.Write("Enter Age : ");
            //    int a;
            //    bool flag;
            //    do
            //    {
            //        flag = int.TryParse(Console.ReadLine(), out a);
            //    } while (!flag || a <= 0);
            //    arr[i].Age = a;

            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion


            #region Q3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            
            bool isparsed;
            Season seasonName;
            do {
                Console.Write("Enter the season Name : ");
                string input = (Console.ReadLine()).ToLower();
                isparsed = Enum.TryParse<Season>(input,out  seasonName); 
            } while (!isparsed);
            
            if (seasonName == Season.summer)
            {
                Console.WriteLine("june to august");
            }
            else if (seasonName == Season.winter)
            {
                Console.WriteLine("December to February");
            }
            else if (seasonName == Season.spring)
            {
                Console.WriteLine("march to may");
            }
            else if (seasonName == Season.autumn)
            {
                Console.WriteLine("September to November");
            }
            else Console.WriteLine(":(");
            #endregion


            #region Q6.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            Console.Write("Enter Color : ");
            bool flag;
            flag=Enum.TryParse<Color>(Console.ReadLine().ToLower(), out Color color);

            if (flag) Console.WriteLine("Basic color");
            else Console.WriteLine("Primary color");

            #endregion

            #region Q.7
            //float x1, y1;
            //bool flag;
            //Console.WriteLine("For the first point :--");

            //do
            //{
            //    Console.Write("Enter first coordinate : ");
            //    flag = float.TryParse(Console.ReadLine(), out x1);
            //} while (!flag);
            //do
            //{
            //    Console.Write("Enter second coordinate : ");
            //    flag = float.TryParse(Console.ReadLine(), out y1);
            //} while (!flag);

            //Point p1 = new Point(x1,y1);
            //float x2, y2;
            //Console.WriteLine("For the second point :--");
            //do
            //{
            //    Console.Write("Enter first coordinate : ");
            //    flag = float.TryParse(Console.ReadLine(), out x2);
            //} while (!flag);
            //do
            //{
            //    Console.Write("Enter second coordinate : ");
            //    flag = float.TryParse(Console.ReadLine(), out y2);
            //} while (!flag);

            //Point p2= new Point(x2,y2);
            //Console.WriteLine($"the distance between the two points is : {cal_distance(p1,p2)}");
            #endregion


            #region Q8


            ////Person[] arr = new Person[3];
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    arr[i] = new Person();
            ////    Console.Write("Enter Name : ");
            ////    arr[i].Name = Console.ReadLine();
            ////    Console.Write("Enter Age : ");
            ////    int a;
            ////    bool flag;
            ////    do
            ////    {
            ////        flag = int.TryParse(Console.ReadLine(), out a);
            ////    } while (!flag || a <= 0);
            ////    arr[i].Age = a;

            ////}
            ////Person oldestPerson = arr[0];
            ////for (int i = 1; i < arr.Length; i++)
            ////{
            ////    if (arr[i].Age > oldestPerson.Age)
            ////    {
            ////        oldestPerson = arr[i];
            ////    }
            ////}
            ////Console.WriteLine(oldestPerson); 
            #endregion

            #region Extra Q
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 5;

            rect.DisplayInfo();
            rect.Width = -3;
            rect.DisplayInfo();
            #endregion
        }
    }
}