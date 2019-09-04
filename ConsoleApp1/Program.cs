using System;


/*1.隐藏和重写（纵向扩展），可以被重写的是method和property，能被重写的必要三个条件是：函数成员（method和property），可见（public class），签名一样（方法名字一样）
 * 如果不加Virtual和override，那么就是隐藏的关系，用vehicle去实例化一个car，显示结果依然是"I'm running"
 * 加上Virtual和override，那么就是重写的关系，用vehicle去实例化一个car，显示为"Car is running"
 * 
 * 一个object有多样的实现方法，就是多态，多态有很多实现形式，这里的virtual是虚方法，还有抽象类和接口的其他两种方法
 
     */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();

            Console.WriteLine(v.Speed);//property的重写，注意不用加括号，只有method才有括号！！！
        }
    }

    class Vehicle
    {
        private int _speed;
        public virtual int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }


        public virtual void Run()
        {
            Console.WriteLine("I'm running");
            _speed = 100;
        }
    }

    class Car : Vehicle
    {
        private int _rpm;
        public override int Speed
        {
            get { return _rpm/100; }
            set { _rpm =value*100; }
        }



        public override void Run()
        {
            Console.WriteLine("Car is running");
            _rpm = 5000;
        }
    }

    //如果把这个override去掉，Vehicle v = new Rasecar(); 那么v.RUN表示的是"Car is running"。因为调取的都是子类的最新的版本。要用纵向思维思考
    class Rasecar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Rasecar is running");
        }
    }
}
