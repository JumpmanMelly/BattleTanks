using Godot;
using System;

public class Health : Node 
{
    public Image healthBar;
    public float max_health = 100f;
    public float cur_health = 0f;
    
    void Start()
    {
        cur_health = max_health;
        SetHealthBar();
    }

    public void TakeDamage(float DamageAmount)
    {
        cur_health -= DamageAmount;
    }

    public void SetHealthBar() 
    {   
        float my_health = cur_health / max_health;
        // healthBar.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

