using Godot;
using System;
using System.Diagnostics;

public partial class Player : CharacterBody2D
{
    [Export]
    public StateMachine stateMachine;
    public float moveSpeed = 100.0f;
    
    public override void _Ready() 
    {
        stateMachine.Init(this);
    }
    public override void _Process(double delta)
    {
        Vector2 inputDirection  = Input.GetVector("move_left", "move_right", "move_up", "move_down");
        this.Velocity = inputDirection * moveSpeed;
        MoveAndSlide();
    }
}
