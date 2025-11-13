using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Arrow ar1 = new Arrow();
        ar1.SetArrowNum(1);
        ar1.SetSpeed(2);
        ar1.SetRange(3);

        Arrow ar2 = new Arrow();
        ar2.SetArrowNum(1);
        ar2.SetSpeed(2);
        ar2.SetRange(3);

        Arrow ar3 = new Arrow();
        ar3.SetArrowNum(1);
        ar3.SetSpeed(2);
        ar3.SetRange(3);

        MagicBall ball1 = new MagicBall();
        ball1.SetMaxBounce(10);
        ball1.SetSpeed(2);
        ball1.SetRange(3);

        MagicBall ball2 = new MagicBall();
        ball2.SetMaxBounce(10);
        ball2.SetSpeed(2);
        ball2.SetRange(3);

        MagicBall ball3 = new MagicBall();
        ball3.SetMaxBounce(10);
        ball3.SetSpeed(2);
        ball3.SetRange(3);

        ar1.Throw();
        ar2.Throw();
        ar3.Throw();
        ball1.Throw();
        ball2.Throw();
        ball3.Throw();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
