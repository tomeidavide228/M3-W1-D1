using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Archer : Character
{
    public Archer(string name, int hp) : base(name, hp)
    {

    }
    public override void Attack(Character target)
    {
        for (int i = 0; i < 2; i++)
        {
            target.TakeDamage(10);
            Debug.Log($"{GetName()} shot the arrow number {i+1}");
        }
        ;
    }
}

