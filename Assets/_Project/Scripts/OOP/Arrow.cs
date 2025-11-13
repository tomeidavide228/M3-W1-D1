using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Arrow : Bullet
{
    private int _arrowNum;
    public int GetArrowNum() => _arrowNum;
    public void SetArrowNum(int arrowNum)
    {
        _arrowNum = Mathf.Max(0, arrowNum);
    }
    public override void Throw()
    {
        Debug.Log(_arrowNum+ " arrows were shot at " + GetSpeed() + " of speed and " + GetRange() + " of range");
    }
}
