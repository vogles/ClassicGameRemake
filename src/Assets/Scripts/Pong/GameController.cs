using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Ball _ball;

    // Start is called before the first frame update
    void Start()
    {
        var directionX = Random.value < 0.5f ? -1 : 1;
        var directionY = Random.value < 0.5f ? -0.75f : 0.75f;


        _ball.Direction = new Vector2(directionX, directionY);
    }
}
