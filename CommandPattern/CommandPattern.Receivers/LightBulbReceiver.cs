using System;
namespace CommandPattern.Receivers
{
    public class LightBulbReceiver
    {
        private int _brightness;
        public int Brightness 
        {
            get { return _brightness; }
            set 
            { 
                if (value <= 100 || value >= 0)
                    _brightness = value; 
            }
        }

        public LightBulbReceiver(int brightness = 0)
        {
            Brightness = brightness;
        }
    }
}
