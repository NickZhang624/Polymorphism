using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            //v.Run();
            //这里是没有办法调用Run的，因为只有一个stop的方法的在父类里面

            //解决方案是：
            //1.在父类里面加一个 Public virtual void Run(){Console.WriteLine("Vehicle is running!");}
            // 然后在子类里面的Run反法用override的方式去重写，那么V就可以有Run的方法了。

            //2.用abstract的方法
            //先给一个纯虚的方法在父类 public abstract void Run(){}，
            //因为这个成员变成abstract，所以该类也要变成abstract class
            //如果再添加一个子类racecar, 那么他的method必须是override的，因为他的继承的父类Run的方法是纯虚的，
        }
    }

    class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
    }

    class Car: Vehicle
    {
        public void Run()
        {
            Console.WriteLine("car is running!");
        }
    }

    class Truck: Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running!");
        }
    }
}

