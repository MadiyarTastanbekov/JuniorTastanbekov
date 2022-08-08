using System;
using JuniorTastanbekov.Cars;
namespace JuniorTastanbekov
{
    class Program
    {
        static void Main(string[] args)
        {

            PassengerCar passengerCar = new PassengerCar();
            Console.WriteLine("Введите среднего расхода топлива ");
            double AverageFuelConsumption = Convert.ToDouble(Console.ReadLine());
            double number2 = AverageFuelConsumption;
            while (number2 < 5 || number2 >= 15)
            {
                Console.WriteLine("Введите среднего расхода топлива ");
                 AverageFuelConsumption = Convert.ToDouble(Console.ReadLine());
                passengerCar.AverageFuelConsumption = AverageFuelConsumption;
                number2 = passengerCar.AverageFuelConsumption;
            }
            Console.WriteLine("Введите объем топливного бака");
            double FuelTankCapacity = Convert.ToInt32(Console.ReadLine());
            passengerCar.FuelTankCapacity = FuelTankCapacity;
            Console.WriteLine("Введите скорость");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите груз ");
            double cargo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество перевозимых пассажиров ");
            int passenger = Convert.ToInt32(Console.ReadLine());
           int number= passengerCar.NumberofPassengersTransported(passenger);
            while (number==0 || number>=5)
            {
                passenger = Convert.ToInt32(Console.ReadLine());
                number = passengerCar.NumberofPassengersTransported(passenger);
            }
           
            Console.WriteLine();
            Console.WriteLine("Опишите метод, с помощью которого можно вычислить сколько автомобиль может проехать на полном баке топлива или на остаточном количестве топлива в баке на данный момент.");
            Console.WriteLine(passengerCar.CanPass());
            Console.WriteLine("Метод для отображения текущей информации о состоянии запаса хода в зависимости от пассажиров и груза. ");
            Console.WriteLine(passengerCar.PowerReserveStatus(passenger, cargo));
            Console.WriteLine("Введите ростояние ");
            double setdistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Метод, который на основе параметров количества топлива и заданного расстояния вычисляет за сколько автомобиль его преодолеет.");
            passengerCar.TimeSpeed(setdistance, speed);
            Console.ReadLine();
        }
    }
}
