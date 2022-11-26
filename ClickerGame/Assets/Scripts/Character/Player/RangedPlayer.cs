using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedPlayer : Player, IFightable
{
    public static RangedPlayer Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (GameManager.Instance.IsStarted)
        {
            SetStates();
        }
        UpdateHealthBar();
    }
    public override void IdleState()
    {
        Target = FindTarget();
        if (Target != null)
        {
            CurrentState = CharacterStates.Fight;
        }
    }
    public override void FightState()
    {
        if (Target.gameObject.GetComponent<Character>().CurrentHealth > 0)
        {
            Attack();
        }
        else
        {
            CurrentState = CharacterStates.Idle;
        }
    }
    public override void DyingState()
    {
        CurrentState = CharacterStates.Death;
    }

    public override void DeathState()
    {
        Destroy(gameObject, 3f);
    }
    public override GameObject FindTarget()
    {
        return GameObject.FindGameObjectWithTag("Enemy");
    }
}
