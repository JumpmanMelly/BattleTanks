using Godot;
using System;

public class DamageTick : Node
{
    float speed = 200f;
    float damage = 5f;
    // used for initialization 
    void Start() 
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Transform.Rotate (Vector3.Up * Time.deltaTime * speed);
    }

    void OnTriggerEnter (CollisionObject other)
    {
        // other.gameObject.GetComponent<Health>().TakeDamage(damage);
    }
}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

