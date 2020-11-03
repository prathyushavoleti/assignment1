using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DecoratorDesignPattern.CarDecorator;

namespace DecoratorDesignPattern
{
    public interface Icar
    {
        string Make { get; }
        double GetPrice();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Icar car = new MarutiSuziki();
            CarDecorator decorator = new offerprice(car);
            Console.WriteLine(string.Format("Make :{0} Price:{1} Discountprice :{2}", decorator.Make, decorator.GetPrice().ToString(), decorator.GetDiscountedPrice().ToString()));
            Console.ReadLine();
        }
    }
    //concrete component
    public sealed class Hyundai : Icar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
    //concrete component
    public sealed class MarutiSuziki : Icar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 750000;
        }
    }

    public abstract class CarDecorator : Icar
    {
        private Icar car;
        public CarDecorator(Icar Car)
        {
            car = Car;
        }
        public string Make {
            get
            {
                return car.Make;
            }
        }
        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();

        public class offerprice : CarDecorator
        {
            public offerprice(Icar car):base(car)
            {

            }
            public override double GetDiscountedPrice()
            {
                return 0.8*base.GetPrice();
            }
        }
    }
}
