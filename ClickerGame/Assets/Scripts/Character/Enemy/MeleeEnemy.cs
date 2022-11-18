using UnityEngine;

public class MeleeEnemy : Enemy, IFightable
{
    public static MeleeEnemy Instance;
    private void Awake()
    {
        characterSO = Resources.Load<CharacterSO>("ScriptableObjects/MeleeEnemy");
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
        Anim.Play("Idle01");
        Target = FindTarget();
        if(Target != null)
        {
            CurrentState = CharacterStates.Fight;
        }
    }
    public override void FightState()
    {
        Anim.Play("Attack01");
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
        Anim.Play("Die01");
        Destroy(gameObject, 2f);
    }
    public override GameObject FindTarget()
    {
        return GameObject.FindGameObjectWithTag("Player");
    }
}
