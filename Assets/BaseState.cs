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
    public abstract void OnStateEnter(); // ���¿� ó�� ���Խ� �ѹ� ȣ�� �Ǵ� �޼���
    public abstract void OnStateUpdate(); // �� �����Ӹ��� ȣ�� �Ǵ� �޼���
    public abstract void OnStateExit(); // ���°� ����Ǹ� ȣ�� �Ǵ� �޼���
}
