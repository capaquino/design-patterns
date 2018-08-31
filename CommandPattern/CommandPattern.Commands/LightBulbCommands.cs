using System;
using CommandPattern.Interfaces;
using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    public abstract class LightBulbCommand : ICommand
    {
        protected LightBulbReceiver light;

        // Setting the constructor to protected allows 
        // you to call base() in child constructors
        protected LightBulbCommand(LightBulbReceiver l)
        {
            light = l;
        }

        public abstract void Execute();
        public abstract void Unexecute();
    }

    public class LightOnCommand : LightBulbCommand
    {
        public LightOnCommand(LightBulbReceiver l) : base(l) { }

        public override void Execute()
        {
            light.Brightness = 100;
        }

        public override void Unexecute()
        {
            light.Brightness = 0;
        }
    }

    public class LightOffCommand : LightBulbCommand
    {
        public LightOffCommand(LightBulbReceiver l) : base(l) { }

        public override void Execute()
        {
            light.Brightness = 0;
        }

        public override void Unexecute()
        {
            light.Brightness = 100;
        }
    }

    public class LightHalfwayCommand : LightBulbCommand
    {
        public LightHalfwayCommand(LightBulbReceiver l) : base(l) { }

        private int prevBrightness; // code smell? How else would we do it?

        public override void Execute()
        {
            prevBrightness = light.Brightness;
            light.Brightness = 50;
        }

        public override void Unexecute()
        {
            light.Brightness = prevBrightness;
        }
    }

    public class LightDuskCommand : LightBulbCommand
    {
        public LightDuskCommand(LightBulbReceiver l) : base(l) {}

        private int prevBrightness; // code smell? How else would we do it?

        public override void Execute()
        {
            prevBrightness = light.Brightness;
            light.Brightness = 30; // "Dusk" brightness level
        }

        public override void Unexecute()
        {
            light.Brightness = prevBrightness;
        }
    }
}
