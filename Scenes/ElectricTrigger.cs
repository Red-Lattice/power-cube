using Godot;
using System;

public partial class ElectricTrigger : StaticBody2D
{
	public AnimatedSprite2D sprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		 sprite = GetParent().GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void setActivationStatus(bool status)
	{
		if (status)
		{
			sprite.Play("Activated"); 
		}
		else
		{
			sprite.Play("Idle"); 
		}
	}
}
