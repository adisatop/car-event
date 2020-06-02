using System;

namespace Driving_car
{
    class Program
    {

        static void Main(string[] args)
        {

            Car car = new Car();
            DriveSpeedManager speedManager = new DriveSpeedManager();//subscriber 
            DriveCar driveCar = new DriveCar(car); //publisher
            driveCar._changeEvent += speedManager.checkIfItsNeedStopingForGaz;
            driveCar._changeEvent += speedManager.showMySpeed;
            driveCar._changeEvent += speedManager.handleDrivingOverLimit;
            driveCar._changeEvent += speedManager.stopCar;
            driveCar._changeEvent += speedManager.sendMessageWhenCarIsStop;

            driveCar._whenCarNeedGaz += GazManager.carIsStopForGaz;





            driveCar.startDriving(20);

        }
    }
}
