using System;
namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
