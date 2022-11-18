using UnityEngine;


public abstract class Enemy : Character
{
    private void Start()
    {
        CurrentState = CharacterStates.Idle;
        Target = FindTarget();
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

    public abstract void DeathState();

    public abstract GameObject FindTarget();
}
