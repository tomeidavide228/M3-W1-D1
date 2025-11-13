using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string name, int hp): base(name, hp) 
    {
        
    }
    public override void Attack(Character target)
    {
        target.TakeDamage(10);
        Debug.Log($"{GetName()} attack with the sword");
    }
}
