using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private enum State
    {
        Idle;
        Move;
        Attack;
    }

    private State _state;
    
    private void Start()
    {
        _state = State.Idle;
    }
    private void Update()
    {
        switcj(_state){
            
            case State.Idle;
                //Idle �ൿ ����
                break;
            case State.Move;
                //Move �ൿ ����
                break;
            case State.Attack;
               //Atack �ൿ ����
                break;
        }
       }   
