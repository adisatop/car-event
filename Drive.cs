using System;
using System.Collections.Generic;
using System.Text;

namespace Driving_car
{
    
    
    class DriveCar
    {
        public delegate void ChangeCarSpeed(object o, Car e);
        public event ChangeCarSpeed _changeEvent;
        public event ChangeCarSpeed _whenCarNeedGaz;
        public int increaseBy = 5;
        Car car;
        public DriveCar(Car car) {
            this.car = car;
        }

        //The main function that driving the car
        public void startDriving(int driveSpeed) {

            for (int i = 0; i < driveSpeed; i++)
            {
                //checking if car is in middle of stop operation
                if (car.shouldStop == false) {
                    car.speedUp(increaseBy);
                }
                // if the car speed is 0 it means that the car is have been stop so we should stop calling event
                if (car.currentSpeed > 0) { 
                onSpeedChanged(car);
                }

                if (car.stopForFillingGaz) {
                    onCarStopForGaz(car);
                    break;
                }
            }
        }

        // firing the methods that we subscribe to _changeEvent event 
        public void onSpeedChanged(Car c) {
            if (_changeEvent != null) {
                _changeEvent(this, c);
            }
        }

        public void onCarStopForGaz(Car c)
        {
            if (_whenCarNeedGaz != null)
            {
                _whenCarNeedGaz(this, c);
            }
        }
    }
}
