using System;
using System.Collections.Generic;
using System.Text;

namespace Driving_car
{
    class Car
    {
        public int currentSpeed;
        public int maxSpeed;
        public int warningTimes;
        public bool shouldStop;
        public bool carStop;
        public bool stopForFillingGaz;
        public int gazIndicator;


        public Car() {
            maxSpeed = 70;
            currentSpeed = 0;
        }

        internal void speedUp(int speed)
        {
            this.currentSpeed+= speed;
        }
    }
}
