using System;
using System.Diagnostics;

namespace ArdiFin.CommandLib
{
    public interface ICommand { }
    public abstract class Command : ICommand
    {
        Process Proc { get; set; }
    }
}
