using System.Collections;
using System.Collections.Generic;
using UnityEditor.Media;
using UnityEngine;

public class Character
{
    private string _name;
    private int _hp;

    public string GetName() => _name;
    public void SetName(string name)
    {
        _name = name;
    }

    public int GetHP() => _hp;
    public void SetHP(int hp)
    {
        _hp = Mathf.Max(0, hp);
    }
    public Character(string name, int hp)
    {
        SetName(name);
        SetHP(hp);
    }

    public void TakeDamage(int damage)
    {
        _hp = Mathf.Max(0, _hp - damage);
    }
    public virtual void Attack(Character target)
    {
        target.TakeDamage(1);
    }

}
