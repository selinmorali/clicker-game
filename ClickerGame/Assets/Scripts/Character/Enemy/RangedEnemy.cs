using UnityEngine;

public class RangedEnemy : Enemy
{
    public static RangedEnemy Instance;

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

    public override void DeathState()
    {
        LevelManager.Instance.NextStage();
        Destroy(gameObject);
    }

    public override GameObject FindTarget()
    {
        return GameObject.FindGameObjectWithTag("Player");
    }
}
