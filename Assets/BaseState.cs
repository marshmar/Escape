using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected Monster _monster;

    protected BaseState(Monster monster)
    {
        _monster = monster;
    }
    public abstract void OnStateEnter(); // 상태에 처음 진입시 한번 호출 되는 메서드
    public abstract void OnStateUpdate(); // 매 프레임마다 호출 되는 메서드
    public abstract void OnStateExit(); // 상태가 변경되면 호출 되는 메서드
}
