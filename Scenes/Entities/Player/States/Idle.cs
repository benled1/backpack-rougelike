using System.Diagnostics;
using System;
using Godot;

public partial class Idle : State
{
    
    public override Node2D controlledEntity { 
        get 
        {
            Debug.Assert(_player != null);
            return this._player;
        }
        set
        {
            if (value is Player player)
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
        Debug.Print("Entering Idle state...");
    }

    public override void onExit()
    {
        Debug.Print("Exiting Idle state..");
    }

    public override void stateProcess()
    {
        if (this._player.Velocity != Vector2.Zero)
        {
            this._player.stateMachine.changeState("Walking");
        }
        Debug.Print("Current state = Idle...");
    }

}