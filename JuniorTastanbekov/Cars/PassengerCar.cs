using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorTastanbekov.Cars
{
    public class PassengerCar : Car
    {
        public double setdistance, time;
        public int number = 0;
        public double number1 = 0;
        public double number2 = 0;
        public double FuelTankCapacity
        {
            set
            {
                if (value < 0 || value > 80)
                    Console.WriteLine(" Максимальный обьем бага 80 ");
                else
                    number1 = value;
            }
            get { return number1; }
        }
        public double AverageFuelConsumption
        {
            set
            {
                if (value < 5 || value > 15)
                    Console.WriteLine(" Расход среднего  топлива   должно быть между 5 и 15");
                else
                    number2 = value;
            }
            get { return number2; }
        }

       
      
        public int NumberofPassengersTransported(int value)
        {
                if (value < 1 || value > 4)
                {
                    Console.WriteLine("Пасажир должен быть в диапазоне от 1 до 4 \n Занова введите количество перевозимых пассажиров ");
                }
           
                else
                    number = value;

                return number;
        }
        

        public override double PowerReserveStatus(int NumberofPassengersTransported, double cargo)
        {
            double percent = ((4 * cargo) / 200)/100;
            double s1;
            double distance = CanPass();
            switch (NumberofPassengersTransported)
            {

                case 2:
                   
                    return s1 = distance - distance * 0.06 - distance * percent;
                   
                case 3:
                    
                    return s1 = distance - distance * 0.12 - distance * percent;
                  
                case 4:
                    
                    return s1 = distance - distance * 0.18 - distance * percent;
                   
            }

            return 0;
        }

        public override double CanPass()
        {
            double distance = FuelTankCapacity / AverageFuelConsumption; // чтобы найти ростояние объем топливного бака делил на среднего расхода топлива
            return distance;
        }


        public override void TimeSpeed(double setdistance, double speed)
        {
            if (CanPass() < setdistance)
            {
                Console.WriteLine("Объем топливного бака не хватит чтобы пройти ростояние ");
                
            }
            else
               time = setdistance / speed;
            Console.WriteLine(time);

        }
    }
}

