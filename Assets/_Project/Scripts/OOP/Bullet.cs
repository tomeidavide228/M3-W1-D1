using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet
{
    private float _speed;
    private float _range;

    public float GetSpeed() => _speed;
    public void SetSpeed(int speed)
    {
        _speed = Mathf.Max(0, speed);
    }
    public float GetRange() => _range;
    public void SetRange(int range)
    {
        _range = Mathf.Max(0, range);
    }
    public virtual void Throw()
    {

    }
}
