using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Monster
{
    private enum State
    {
        Idle,
        Move,
        Attack
    }
    private State _curstate;
    private FSM _fsm;

    private void Start()
    {
        _curstate = State.Idle;
        _fsm = new FSM(new IdleState(this));
    }

    private void Update()
    {
        switch (_curstate)
        {
            case State.Idle:
                if (CanSeePlayer())
                {
                    if (CanAttackPlayer())
                        ChangeState(State.Attack);
                    else
                        ChangeState(State.Move);
                }
                break;
            case State.Move:
                if (CanSeePlayer())
                {
                    if (CanAttackPlayer())
                    {
                        ChangeState(State.Attack);
                    }
                }
                else
                {
                    ChangeState(State.Move);
                }
                break;
            case State.Attack:
                if(CanSeePlayer())
                {
                    if(!CanAttackPlayer())
                    {
                        ChangeState(State.Move);
                    }
                }
                else
                {
                    ChangeState(State.Idle);
                }
                break;
        }
        _fsm.UpdateState();
    }

    private void ChangeState(State nextState) 
    {
        _curstate = nextState;
        switch(_curstate)
        {
            case State.Idle:
                {
                    _fsm.ChangeState(new IdleState(this));
                    break;
                }
            case State.Move:
                {
                    _fsm.ChangeState(new MoveState(this));
                    break;
                }
            case State.Attack:
                {
                    _fsm.ChangeState(new AttackState(this));
                    break;
                }
        }
    }
    private bool CanSeePlayer()
    {
        return true;
    }
    private bool CanAttackPlayer()
    {
        return false;
    }
}
