// Strategy Pattern is dependency injection
// Observer Pattern is events
// Decorator Pattern is extendability and a way to replace subclasses
// Factory Pattern handles instantiation where the type of the object that
//   needs to be created is determined at runtime (like user literally types
//   in what kind of object they want from a list of objects).

using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Invokers
{
    // Four button remote whose buttons are programmable
    // How would we actually know a button is pressed?
    // Kappa: Observer pattern
    public class Remote
    {
        private ICommand circleButton;
        private ICommand squareButton;
        private ICommand triangleButton;
        private ICommand exButton;

        public Remote(ICommand c1, ICommand c2, ICommand c3, ICommand c4)
        {
            circleButton = c1;
            squareButton = c2;
            triangleButton = c3;
            exButton = c4;
        }

        // Say you had like a dial or any other potentiometer-like input.
        // public void DialActivated(DialEventsArgs e)
        //{
        //    ... well actually the command is already supposed to have that
        //    info upon instantiation so the detection of the input is going to 
        //    be somewhere else. Maybe in a main() loop of a microcontroller?
        //}

        public void PressCircleButton()
        {
            circleButton.Execute();
        }

        public void PressSquareButton()
        {
            squareButton.Execute();
        }

        public void PressTriangleButton()
        {
            triangleButton.Execute();
        }

        public void PressExButton()
        {
            exButton.Execute();
        }


        /*
        // Event Consumers, see main file.
        public void CircleButtonPressed(object sender, EventArgs e)
        {
            circleButton.Execute();
        }

        public void SquareButtonPressed(object sender, EventArgs e)
        {
            squareButton.Execute();
        }

        public void TriangleButtonPressed(object sender, EventArgs e)
        {
            triangleButton.Execute();
        }

        public void ExButtonPressed(object sender, EventArgs e)
        {
            exButton.Execute();
        } */
    }
}
