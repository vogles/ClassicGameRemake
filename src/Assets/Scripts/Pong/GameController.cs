using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public enum GameState
    {
        Idle,
        Playing,
        LeftWon,
        RightWon,
    }

    [SerializeField] private Ball _ball;

    private GameState _state;

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(GameState.Idle);
    }

    public void ChangeState(GameState state)
    {
        if (state == _state)
        {
            return;
        }

        switch (state)
        {
            case GameState.Idle:
                _ball.Position = Vector2.zero;
                _ball.Direction = Vector2.zero;
                break;
            case GameState.Playing:
                var directionX = Random.value < 0.5f ? -1 : 1;
                var directionY = Random.value < 0.5f ? -0.75f : 0.75f;
                _ball.Direction = new Vector2(directionX, directionY);
                break;
            case GameState.LeftWon:
                _ball.Position = Vector2.zero;
                _ball.Direction = Vector2.zero;
                break;
            case GameState.RightWon:
                _ball.Position = Vector2.zero;
                _ball.Direction = Vector2.zero;
                break;
        }

        _state = state;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ChangeState(GameState.Playing);
        }
    }
}
