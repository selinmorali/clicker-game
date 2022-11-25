using UnityEngine;

public class MeleePlayer : Player, IFightable
{
    public static MeleePlayer Instance;
    private void Awake()
    {
        characterSO = Resources.Load<CharacterSO>("ScriptableObjects/MeleePlayer");
        Instance = this;
        CurrentHealth = characterSO.MaxHealth;
        Anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (GameManager.Instance.IsStarted)
        {
            SetStates();
        }
        CheckHealth();
        UpdateHealthBar();
    }

    public override void IdleState()
    {
        Anim.SetBool("isIdle", true);
        Anim.SetBool("isAttack", false);
        Anim.SetBool("isDie", false);
        Target = FindTarget();
        if (Target != null)
        {
            CurrentState = CharacterStates.Fight;
        }
    }

    public override void FightState()
    {
        Anim.SetBool("isAttack", true);
        Anim.SetBool("isIdle", false);
        Anim.SetBool("isDie", false);

        if (Target != null && Target.gameObject.GetComponent<Character>().CurrentHealth > 0)
        {
            Attack();
        }
        else
        {
            Target = null;
            CurrentState = CharacterStates.Idle;
        }
    }

    public override void DeathState()
    {
        Anim.SetBool("isDie", true);
        Anim.SetBool("isIdle", false);
        Anim.SetBool("isAttack", false);
        Destroy(gameObject);       
    }

    public override GameObject FindTarget()
    {
        return GameObject.FindGameObjectWithTag("Enemy");
    }
}
