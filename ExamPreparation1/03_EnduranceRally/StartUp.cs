using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_EnduranceRally
{
    public class StartUp
    {
        public static void Main()
        {
            var inputDrivers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            
            var zoneList = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var checkPoints = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        
         List<Driver>drivers=new List<Driver>();

            foreach (var inputDriver in inputDrivers)
            {
                Driver driver=new Driver(inputDriver);
                drivers.Add(driver);
            }

            foreach (var driver in drivers)
            {
                for (int i = 0; i < zoneList.Count; i++)
                {
                    bool isCheckPoint = checkPoints.Contains(i);
                    driver.ChangeFuel(zoneList[i],isCheckPoint);
                    driver.ChangeReachedZone(i);
                    if (driver.Fuel<=0)
                    {
                        break;
                    }
                    
                }
            }

            foreach (var driver in drivers)
            {
                if (driver.Fuel<=0)
                {
                    Console.WriteLine($"{driver.Name} - reached {driver.ReachedZone}");
                }
                else
                {
                    Console.WriteLine($"{driver.Name} - fuel left {driver.Fuel:f2}");
                }
            }
        }
    }

    public class Driver
    {
        public Driver(string name)
        {
            this.Name = name;
            this.Fuel = (int)this.Name[0];
            this.ReachedZone = 0;
        }
        
        public string Name { get; set; }
        public double Fuel { get; set; }
        public int ReachedZone { get; set; }

        public void ChangeReachedZone(int i)
        {
            this.ReachedZone = i;
        }

        public void ChangeFuel(double fuel, bool isCheckpoint)
        {
            if (isCheckpoint)
            {
                this.Fuel += fuel;
            }
            else
            {
                this.Fuel -= fuel;
            }
        }
        
    }
}
