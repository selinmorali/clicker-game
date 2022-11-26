using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Player : Character
{
    private void Start()
    {
        CurrentState = CharacterStates.Idle;
    }

    public void SetStates()
    {
        switch (CurrentState)
        {
            case CharacterStates.Idle:
                IdleState();
                break;
            case CharacterStates.Fight:
                FightState();
                break;
            case CharacterStates.Dying:
                DyingState();
                break;
            case CharacterStates.Death:
                DeathState();
                break;
            default:
                IdleState();
                break;
        }
    }
    public abstract void IdleState();

    public abstract void FightState();

    public abstract void DyingState();

    public abstract void DeathState();

    public abstract GameObject FindTarget();
}