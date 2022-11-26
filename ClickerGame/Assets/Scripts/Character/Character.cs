using UnityEngine;
using UnityEngine.UI;

public abstract class Character: MonoBehaviour
{
    public enum CharacterStates
    {
        Idle,
        Fight,
        Dying,
        Death,
        Victory
    };
    public CharacterStates CurrentState;

    public Image HealthBar;
    public float CurrentHealth;
    public GameObject Target = null;
    public CharacterSO characterSO;
    [HideInInspector]public Animator Anim;
    public void UpdateHealthBar()
    {
        HealthBar.fillAmount = CurrentHealth / characterSO.MaxHealth;
    }

    public void Attack()
    {
        if (characterSO.AttackCooldown <= 0f)
        {
            if (Target != null)
            {
                Transform targetsHitPoint = Target.GetComponent<Character>().characterSO.HitPoint.transform;
                GameObject effectIns = Instantiate(characterSO.HitEffect, targetsHitPoint.position, targetsHitPoint.rotation);
                Destroy(effectIns, 1f);
                DealDamage(characterSO.AttackDamage);
            }
            else
            {
                CurrentState = CharacterStates.Idle;
            }
            characterSO.AttackCooldown = 1f / characterSO.AttackSpeed;
        }
        characterSO.AttackCooldown -= Time.deltaTime;
    }
    public void DealDamage(float damage)
    {
        Target.GetComponent<Character>().CurrentHealth -= damage;
    }

    public void CheckHealth()
    {
        if(CurrentState != CharacterStates.Death && CurrentHealth <= 0)
        {
            CurrentState = CharacterStates.Dying;
        }
    }
}
