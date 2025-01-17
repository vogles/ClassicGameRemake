using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
    private Ball _ball;

    protected override void Awake()
    {
        _ball = FindObjectOfType<Ball>();

        base.Awake();
    }

    private void Update()
    {
        if (_ball != null)
        {
            var direction = Direction;
            direction.y = _ball.Position.y < Position.y ? -1 : 1;
            Direction = direction;
        }
    }
}
