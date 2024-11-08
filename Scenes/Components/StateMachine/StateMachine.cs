using Godot;
using System;
using System.ComponentModel;

public partial class StateMachine : Node
{
    [Export]
    public State startingState;
    public State currentState;

    public void Init(Node2D parent) 
    {
        foreach (State child_state in this.GetChildren())
        {
            child_state.parent = parent;
        }
    }

    public void changeState(State newState)
    {
        if (this.currentState != null)
        {
            this.currentState.onExit();
        }
        this.currentState = newState;
        this.currentState.onEnter();
    }
    public void Process() {}

}
