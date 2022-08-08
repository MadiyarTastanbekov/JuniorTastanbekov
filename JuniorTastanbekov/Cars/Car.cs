using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorTastanbekov
{
   public abstract class Car
    {
        double AverageFuelConsumption { get; set; }
        double FuelTankCapacity { get; set; }
        double Speed { get; set; }
        public abstract double CanPass();
        public abstract double PowerReserveStatus(int passenger, double cargo);
        public abstract void TimeSpeed(double setdistance, double speed);

    }
}
