using System;
using System.Collections.Generic;
using System.Text;

namespace Driving_car
{
    //Responsible for handling car speed
    class DriveSpeedManager
    {
        
        // checking if the speed is in limited range
        // If current speed is greater than limit, we warning 3 times before stopping the car
        internal void handleDrivingOverLimit(object o, Car car)
        {
            if (car.shouldStop == false)
            {
                if (car.currentSpeed > car.maxSpeed)
                {
                    Console.WriteLine("you are driving over the limited speed!");
                    car.warningTimes++;
                    if (car.warningTimes >= 3)
                    {
                        car.shouldStop = true;
                    }
                }
            }


        }


        internal void stopCar(object o, Car car)
        {
            if (car.shouldStop && car.currentSpeed>0)
            {
                Console.WriteLine("stopping the car since you over the limited speed");
                for (int i = 0; i < car.currentSpeed; i++)
                {
                    slowDown(1, car);
                }
            }
        }

        internal void showMySpeed(object o, Car e)
        {
            Console.WriteLine("Current speed: " + e.currentSpeed);
        }


        internal void sendMessageWhenCarIsStop(object o, Car e)
        {
            if (e.currentSpeed == 0)
            {
                Console.WriteLine("The car stop!");
            }

        }

        internal void speedUp(int driveSpeed,Car car)
        {
            car.speedUp(driveSpeed);
        }


        internal void checkIfItsNeedStopingForGaz(object o, Car car)
        {
            DriveCar dc = (DriveCar)o;
            if (dc.increaseBy>= 5) {
                car.gazIndicator++;
            }
            if (car.gazIndicator >= 3) {
                car.stopForFillingGaz = true;
                Console.WriteLine("The car is stopping for gaz");
                car.currentSpeed = 0;
                car.shouldStop = true;
            }
        }

        internal void slowDown(int driveSpeed,Car car)
        {
            car.currentSpeed--;
            Console.WriteLine("slowing down the speed");
        }


    }
}
