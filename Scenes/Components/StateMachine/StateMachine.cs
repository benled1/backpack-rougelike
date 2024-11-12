using Godot;
using System.Collections.Generic;

public partial class StateMachine : Node
{
    [Export]
    public State startingState;
    public State currentState;
    public Dictionary<string, State> states = new Dictionary<string, State>();

    public void Init(Node2D parent) 
    {
        foreach (State child_state in this.GetChildren())
        {
            states.Add(child_state.Name, child_state);
            child_state.controlledEntity = parent;
        }
        this.changeState(startingState.Name);
    }

    public void changeState(string newState)
    {
        if (this.currentState != null)
        {
            this.currentState.onExit();
        }
        this.currentState = this.states[newState];
        this.currentState.onEnter();
    }

    public void Process() 
    {
        this.currentState.stateProcess();
    }

}
