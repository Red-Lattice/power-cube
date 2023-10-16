using Godot;
using System;

public partial class AuraTrigger : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	void _on_Area2D_body_entered(Node2D body)
	{
		if (body.Name == ("ElectricTriggerStaticBody"))
		{
			GD.Print("fail");
			(body as ElectricTrigger).setActivationStatus(true);
		}
	}
	void _on_Area2D_body_exit(Node2D body)
	{
		if (body.Name == ("ElectricTriggerStaticBody"))
		{
			GD.Print("go");
			(body as ElectricTrigger).setActivationStatus(false);
		}
	}
}
