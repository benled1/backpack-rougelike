using System.Diagnostics;
using Godot;



public abstract partial class State: Node
{
    public virtual Node2D controlledEntity {get; set;}
    public abstract void onEnter();
    public abstract void onExit();
    public abstract void stateProcess();
}


