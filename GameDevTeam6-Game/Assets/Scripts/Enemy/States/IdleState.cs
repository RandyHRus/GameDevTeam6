﻿using System;
using System.Collections;

internal class IdleState: IState
{
    private EnemyAI parent;

    public void Enter(EnemyAI parent)
    {
        this.parent = parent;
    }

    public void Exit()
    {

    }

    public void Update()
    {

    }
}

