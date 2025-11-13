using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Mage(string name, int hp) : base(name, hp)
    {

    }
    public override void Attack(Character target)
    {
            target.TakeDamage(12);
            Debug.Log($"{GetName()} cast a spell");
    }
}
