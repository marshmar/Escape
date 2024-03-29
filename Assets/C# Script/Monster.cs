using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private enum State
    {
        Idle,
        Move,
        Attack
    }
    private State _state;

    private void Start()
    {
        _state = State.Idle;
    }

    private void Update()
    {
        switch(_state)
        {
            case State.Idle:
                break;

            case State.Move:
                break;

            case State.Attack:
                break;
        }
    }
}
