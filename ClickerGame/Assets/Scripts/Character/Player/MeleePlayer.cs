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
        Anim.Play("Idle_Normal_SwordAndShield");
        Target = FindTarget();
        if (Target != null)
        {
            CurrentState = CharacterStates.Fight;
        }
    }
    public override void FightState()
    {
        Anim.Play("Attack02_SwordAndShiled");
        if (Target.gameObject.GetComponent<Character>().CurrentHealth > 0)
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
        Anim.Play("Die01_SwordAndShield");
        Destroy(gameObject, 2f);
    }
    public override GameObject FindTarget()
    {
        return GameObject.FindGameObjectWithTag("Enemy");
    }
}
