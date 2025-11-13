using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : Bullet
{
    private int _maxBounce;
    public int GetMaxBounce() => _maxBounce;
    public void SetMaxBounce(int maxBounce)
    {
        _maxBounce = Mathf.Max(0, maxBounce);
    }
    public override void Throw()
    {
        int bounce = Random.Range(0, _maxBounce);
        Debug.Log("The magic ball bounced " + bounce + " times at " + GetSpeed() + " of speed and " + GetRange() + " of range");
    }
}
