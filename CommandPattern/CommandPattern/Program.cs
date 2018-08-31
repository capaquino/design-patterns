/*
 * * * * * Command Pattern * * * * *
        references
ICommand <------ ConcreteCommands

   ^                   |
   | references        | references
   |                   v

Invoker            Receiver

*/

using System;
using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Whip up a receiver (the light bulb)
            LightBulbReceiver myLamp = new LightBulbReceiver();

            // Whip up some commands and pass the receiver so the commands
            // know which light bulb to change.
            LightOnCommand on = new LightOnCommand(myLamp);
            LightOffCommand off = new LightOffCommand(myLamp);
            LightHalfwayCommand half = new LightHalfwayCommand(myLamp);
            LightDuskCommand dusk = new LightDuskCommand(myLamp);

            // Create the remote and attach the commands to each button
            Remote remote = new Remote(on, // circle
                                       off, // square
                                       half, // triangle
                                       dusk /* ex */ );

            remote.PressCircleButton();
            Console.WriteLine(myLamp.Brightness);
            remote.PressSquareButton();
            Console.WriteLine(myLamp.Brightness);
            remote.PressTriangleButton();
            Console.WriteLine(myLamp.Brightness);
            remote.PressExButton();
            Console.WriteLine(myLamp.Brightness);

            /* Event Handler reminder 
            // "Press" some buttons, could do this using a UI. Not sure how
            // to convert a console project to a UI, or if it's even possible.
            ButtonPresser presser = new ButtonPresser();
            presser.CircleButtonPressed += remote.CircleButtonPressed;
            presser.PressCircleButton(); */
        }
    }

    /*
    // So this is actually pointless but I was doing it because I forgot how
    // event handlers worked. It just adds an unnecessary layer. If we really
    // just wanted to press the button the remote, we could do some in Main()
    public class ButtonPresser
    {
        // Event creator
        public event EventHandler CircleButtonPressed;

        // Checks that we have subscribers and if so, fires the event.
        protected virtual void OnCircleButtonPressed(EventArgs e)
        {
            CircleButtonPressed?.Invoke(this, e);
        }

        // Business logic to determine whether to fire the event
        public void PressCircleButton()
        {
            Console.WriteLine("Circle Button Pressed!");
            OnCircleButtonPressed(EventArgs.Empty);
        }
    }*/
}