using System.Diagnostics;
using System;
using Godot;

public partial class Walking : State
{
    public override Node2D controlledEntity { 
    get 
    {
        Debug.Assert(_player != null);
        return this._player;
    }
    set
    {
        if (value is Player player) // this line does type checking when trying to set.
        {
            this._player = player;
        }
        else
        {
            throw new InvalidCastException("Cannot assign a non-Player object.");
        }
    }
    }
    private Player _player;
    override public void onEnter() 
    {
        Debug.Print("Entering Walking state...");
    }

    public override void onExit()
    {
        Debug.Print("Exiting Walking state..");
    }

    public override void stateProcess()
    {
        if (this._player.Velocity == Vector2.Zero)
        {
            this._player.stateMachine.changeState("Idle");
        }
        Debug.Print("Current state = Walking...");
    }

}