using Godot;
using System;

using AudioClip = Godot.AudioStreamPlayer3D;

public class AmmoReload : Node
{   
    public AudioClip shotSound;
    public AudioClip reloadSound;
    public AudioClip clickSound; //option "no bullets" click sound
    public int clips = 2; //how many clips you have
       public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
