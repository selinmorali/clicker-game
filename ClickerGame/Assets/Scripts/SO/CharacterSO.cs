using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character Scriptable Object", order = 1)]
public class CharacterSO : ScriptableObject
{
    public int MaxHealth;
    public int AttackSpeed;
    public int AttackDamage;
    public float AttackCooldown = 0f;
    public GameObject HitPoint;
    public GameObject FirePoint;
    public GameObject HitEffect;
}
