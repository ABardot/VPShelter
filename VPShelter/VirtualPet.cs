using System;

namespace VPShelter
{
    public abstract class VirtualPet // You should also have a VirtualPet class in a separate file.
    {
        // Fields (at least three)
        
        private int batteryLevel;
        private int hydraulicPressure;
        
        private bool batteryFixed;
        private bool hydraulicPressureFixed;
        
        // Properties (at least three)
       

        public int BatteryLevel
        {
            get { return this.batteryLevel; }
            set
            {
                this.batteryLevel = value; // I set the range of the field here 
                if (this.batteryLevel < 0)
                {
                    this.batteryLevel = 0;
                }
                if (this.batteryLevel > 100)
                {
                    this.batteryLevel = 100;
                }
            }
        }

        public int HydrolicPressure
        {
            get { return this.hydraulicPressure; }
            set
            {
                this.hydraulicPressure = value;
                if (this.hydraulicPressure < 0)
                {
                    this.hydraulicPressure = 0;
                }
                if (this.hydraulicPressure > 100)
                {
                    this.hydraulicPressure = 100;
                }
            }
        }

       

        public bool BatteryFixed
        {
            get { return this.batteryFixed; }
            set { this.batteryFixed = value; }
        }

        public bool HydraulicPressureFixed
        {
            get { return this.hydraulicPressureFixed; }
            set { this.hydraulicPressureFixed = value; }
        }

        

        // Constructors (at least one)
        public VirtualPet()
        {
            
            this.batteryLevel = 50;
            this.hydraulicPressure = 50;
            
        }

        

        // Methods (at least three)
        public void FixBattery()
        {
            this.batteryLevel += (100 - this.batteryLevel); // Your methods should cause the appropriate properties to update
            
        }

        public void FixHydraulicPressure()
        {
            this.hydraulicPressure += (100 - this.hydraulicPressure);
            
        }

        

        //public void Tick() // Tick method
        //{
        //    if (this.batteryFixed == true)
        //    {
               
        //        this.batteryFixed = false;
        //    }
        //    else if (this.hydraulicPressureFixed == true)
        //    {
        //        this.batteryLevel = (this.batteryLevel > 20 ? this.batteryLevel - 20 : this.batteryLevel + 5);
        //        this.hydraulicPressureFixed = false;
        //    }
        //    else
        //    {
                
        //        this.batteryLevel = (this.batteryLevel > 20 ? this.batteryLevel - 20 : 10);
        //        this.hydraulicPressure = (this.hydraulicPressure > 40 ? this.hydraulicPressure - 40 : 40);
               
        //    }
        //}
    }
}