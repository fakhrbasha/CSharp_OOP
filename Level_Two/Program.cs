// OOP C#
/*
 Classes: 
    (access mod) (class) (nameclass){}
 
            // new car
            // create object  object refrance type -> new
            Car car01 = new Car(); // new object
            car01.color = "Red";
            car01.year = 2002;
            car01.price = 15000.4;
            car01.model = "BMW";

            Car car02 = new Car(); // new object
            car01.color = "Blue";
            car01.year = 2023;
            car01.price = 17.4000;
            car01.model = "Skoda";
------class :
            public class Car
    {
        public string model;
        public int year;
        public double price;
        public string color;
    }
----------------------------------------------
Class Member :
            Car toyota = new Car();
            toyota.price = 100.000;
            toyota.model = "Toyota";
            toyota.color="white";



            toyota.Year = 2004;

            Car Ford=new Car();
            Ford.start();
            Ford.Stop();
            Ford.Year = 2007;
 ------class :
public class Car
    {
        // class member

        // 1.Fields(color , model , price)
        // 2.Method(behavours .. Move .. Stop )
        // 3.Properties (smart Fields)

        public string color; // fields
        public string model;
        public double price;

        private int m_Year;  // private field don't show outside function

        // method
        public void start()
        {
            Console.WriteLine("Car Start");
        }
        public void Stop()
        {
            Console.WriteLine("Car Stop");
        }

        // Proprties (controlled access)
        public int Year //getter
        {
            
            get
            {
                if (m_Year == 0)
                {
                    return 0;
                }
                else
                {
                    return m_Year;
                }
                
            }
            //setter
            set
            {
                m_Year = value; // value keyword constant
            }
        }
    }
 ------------------------------------------
 Constructor:
    
            House h1 = new House(); // object creation
            //h1.Color = "White";
            //h1.Numofroom = 3;
           

            h1.Price = 1334;
            Console.WriteLine(h1.Numofroom); // 3

            House h2 = new House(1000);
            Console.WriteLine(h2.Price); // 1000

            House h3 = new House("Red");
            Console.WriteLine(h3.Numofroom); // 0
            Console.WriteLine(h3.Color); // Red

            House h5 = new House();
            //Constructor chaining هتخلي كلهم يشتغلوا بالترتيب

            Console.WriteLine(h5.Color); // white

--- class & Constructor
            public class House
            {
                public string Color;
                public int Price;
                public int Numofroom;

                // constructor don't need a return type
                // method same name class

                // default Constructor
                public House() : this("White")
                {
           
                    Numofroom = 3;
           
                }

                // Paramtarized (paramtrers)

                public House(int price)
                {
                    Price = price;
                }
                // method overloading
                public House(string color )
                {
                    Color = color;
           
                }

Without Constructor  :                                   With constructor:
class Program                                           class Program
{                                                       {
  static void Main(string[] args)          |              static void Main(string[] args)
  {                                        |               {
    Car Ford = new Car();                  |                  Car Ford = new Car("Mustang", "Red", 1969);
    Ford.model = "Mustang";                |                  Car Opel = new Car("Astra", "White", 2005);
    Ford.color = "red";                    |                   
    Ford.year = 1969;                      |                   Console.WriteLine(Ford.model);
 
    Car Opel = new Car();                  |                  Console.WriteLine(Opel.model);
    Opel.model = "Astra";                  |                }
    Opel.color = "white";                  |             }
    Opel.year = 2005;                      |

    Console.WriteLine(Ford.model);         |
    Console.WriteLine(Opel.model);         |
  }
}
----------------------------------------
Access Modifiers : 
            //Control who can show my method

            // Access Modifier : Visiblity
            // class , member , fields , method , proprties
            // public : Visiblity outside class
            // private : within class
            // if you don't put access modifier by default -> private 

            //internal , protected

-- classess
    // Public Access Modifier 
    public class House
    {
        int area;
        public int GetRoom()
        {
            Villa newVilla = new Villa();
            //newVilla.GetVillaRoom(); // error Becouse Access Modifier Private 
           // newVilla.areaVilla = 13; error becouse private 
            return 3;
        }
    }
    public class Villa
    {
        // Field
       private int areaVilla;
        //Method
        private int GetVillaRoom()
        {
            areaVilla = 13; // تستخدمها جوا الكلاس بس
            return 3;
        }
    }
----------------------------------------
                              OOP Principles
  1. Abstraction     2. Polymorphism    3. Inheritance     4. Encapsulation
                                     A.P.I.E

Properties & Encapsulation : 
            person p1= new person();
            p1.Name = "Fakhr";
            Console.WriteLine(p1.Name);
            p1.Age = 20;
            Console.WriteLine(p1.Age);
            
            // Encapsulation : Data Hiding Set & Get
            // Bundling & hiding
  --- classes
        public class person
        {
            private string _Name;
            private int _Age;
            private double height;

            // method
            public void Talk()
            {

            }
            // Properties 
            public string Name
            {
                //get
                get
                {
                    //logic
                    return _Name;
                }
                    //set 
                set
                {
                    if (value == "fakhr")
                    {
                        Console.WriteLine("Error babe , try another name");
                    }
                    else
                    {
                        _Name = value; // value const word
                    }
                
                }
            }
            // automatic if i don't set a logic
            public int Age
            {
                get; set;
            }
        }
-----------------------------------------------
Inheritance:

            Dog d1 = new Dog();
            d1.Name = "Leo";
            Console.WriteLine(d1.Name);
            d1.weight = 100;
            Console.WriteLine(d1.weight);
            d1.Eat();
            d1.bark();

            Elephant e1 = new Elephant();
            e1.weight = 10033;
            e1.Name = "CR7";
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.weight);
            e1.Eat();
    
------ classes
         //base class , parent class
        class Animal
        {
            public string Name;
            public int weight;

            // overriding
            public virtual void Eat()
            {
                Console.WriteLine("----- Is Eating");
            }
        }


        //child class , derived classes
        class Dog : Animal
        {
            public void bark()
            {
                Console.WriteLine("Hohohoho");
            }
            public override void Eat()
            {
                Console.WriteLine("Dog Is Eating");
            }
        }
    
        class Elephant : Animal
        {
            public override void Eat() // override
            {
                Console.WriteLine("Elephent Is Eating");
            }
        }
        sealed class Garden // Don't use Inher
        {
            public int Area;
            public string Address;
        }
    
       sealed class Garden2 : Garden // error
       {

       }

--------------------------------------
Polymorphism : 
            Animal dog1 = new Dog();

            dog1.Makesound();

            Animal cat1 = new Cat();
            cat1.Makesound();
            Calculator calculator = new Calculator();
            var res = calculator.Add(6.5, 7.5 ,5); //double
            Console.WriteLine(res);

---- class
          // Dynamic Polymorphism (runtime polymorphism)
    class Animal {  // base class
    public virtual void Makesound()
        {
            Console.WriteLine("Animal Make Sound");
        }
    }

    class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Cat Meaw");
        }
    }

    // static polymorphism (method overloading) (Compile Time)

    class Calculator
    {
        public int Add(int a , int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, double b,int s)
        {
            return a + b + s;
        }
    }
--------------------------------------------
Abstraction :
        ClothingShop c = new ClothingShop();
            c.Open();
            c.ColseTheStore();
            FoodShop f = new FoodShop();
            f.Open();

            // Shop shop = new Shop(); error can't create object with abstracr class
            Shop s = new ClothingShop();
            s.ColseTheStore()

--- classes
        abstract class Shop  // abstract 
            {
                public abstract void Open(); // abstract method

                public void ColseTheStore ()  // abstract class contain normal method and abstract method
                { 
                    Console.WriteLine("Store Colsed");
                }
        
            }
            class ClothingShop : Shop
            {
                public override void Open()
                {
                    Console.WriteLine("Clothing shop Open");
                }
            }
            class FoodShop : Shop
            {
                public override void Open()
                {
                    Console.WriteLine("Food Shop Open");

                }
            }
 ----------------------------------------
Interfaces: 
         Rectangle r = new Rectangle();
            r.wid = 23;
            r.len = 34;
            Console.WriteLine( r.CalcArea());
            IShape c = new Circle();
---- classes 
         //interface def

            public interface IExample
            {
                // proprtis , method
            }
    
            // interface >>> Abstraction
            public interface IShape
            {
                double CalcArea();
            }
            public interface Icolor // interface can't use Concrete
            {
                string GetColor(); 
                double CalcArea();
            }
            // inher interface 
            public interface IColorFulShape : IShape , Icolor
            {

            }
    
            public abstract class Shape
            {
                public abstract double GetNum();
                // Concrete
                public string CalcName()
                {
                    return "Diffrant ";
                }  
            }
            public class Rectangle : IColorFulShape  // IShape , Icolor // Multiple Inheritance
            {
                public double len { get; set; }
                public double wid { get; set; }
               double IShape.CalcArea() // كدا هوا هيعرف ان دا بتاع انهي انترفيس ازاي

               {
                    return len * wid;
               }
                double Icolor.CalcArea() // في خالة ودوظ نفس الدالة في كذا انترفيس  
                {
                    return wid;
                }

                public string GetColor() 
                {
                    return "Yellow";
                }
            }
            public class Circle : IShape
            {

                public double Red { get; set; }
                public double CalcArea()
                {
                    return Red * Red * 3.14;
                }
            }
---------------------------------------------
Class Relations :
ASSOCIATION / AGGREGATION / COMPOSITION :
 Uses a        has a         owns a
* ASSOCIATION: كلاس يستخدم كلاس اخر بس لو واحد باظ التاني لا
 
     // Assosiation (uses a) Life-Time
    // Aggregation (has a)  1 to 1 or 1 to many
    // Composition (owns a)
    class Department
    {
        public string Name { get; set; }
    }
    class Company
    {
        public string Name { get; set; }
        public Department Department { get; set; }


    }
    class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }



    }
    class Engine
    {
        public string Model { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public Engine Engine { get; set; }
        //العربية لو اتدمرت ال (Engine) هيتدمر معاها
    }
----------------------------------------- 
Struct :    
            Point p1 = new Point(5,10);
            Console.WriteLine(p1.y); // 10

            Point p2;
            p2 = p1;

            p1.y = 20;  // Don't Change ( Value Type )
            Console.WriteLine(p2.y); // 10

--- Clsses
     // Struct -> Value Type
    // Class -> Refrance Type
    // Don't use inher
    // use Interface
    

    public interface IPoint
    {
        int H { get; }
    }


        public struct Point : IPoint
        {
                public int x;
                public int y;
                public Point(int z, int a) // constrctor
                {
                    x = z;
                    y = a;
                }

                public int H { get; }


                public void MovePoint()
                {
                    x++;
                }


        }
 ------------------------------
Enum :
 

            // Console.WriteLine(Days.thursday);
            var f = (int)Days.thursday; // convert enum to number
            Console.WriteLine(f); // 5


            int x = 3;
            var z = (Days)x; // Convert Number To enum 
            Console.WriteLine(z); // thursday

            Console.WriteLine("Enter Light Line");

            string t=Console.ReadLine();

            int i= Convert.ToInt32(t);

            var input = (TrafficLights) i;
            switch (input)
            {
                case TrafficLights.Green:
                    Console.WriteLine("Go");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Prepare");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

 --- classes --
     enum Days
    {
        saturday,
        sunday,
        monday,
        tuesday,
        wenesday,
        thursday = 10,
        friday // 11
    }
    enum TrafficLights
    {
        Green=1 , 
        Yellow,
        Red
    }
  ------------------------------------------
Static Types:

    calc c = new calc(); 
            calc c2 = new calc();
            Console.WriteLine(calc.number);
            calc c3 = new calc();
            calc.drive();

---- classes 
    public  class calc
    {
        public static int number = 0;
        public calc() // constractor
        {
            number++;
        }

        static calc() // def constractor
        {
            Console.WriteLine("No AcceccMod");
        }
        public static void drive()
        {
            Console.WriteLine("D");
        }
    }
*/



using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Level_Two

{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("CSharp Level-2");
            
        }
    }

    

}


