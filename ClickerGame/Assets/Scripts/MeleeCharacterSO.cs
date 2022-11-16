using UnityEngine;

[CreateAssetMenu (fileName = "MeleeCharacter", menuName = "ScriptableObjects/Melee Character Scriptable Object", order = 1)]
public class MeleeCharacterSO : ScriptableObject
{
    public int MaxHealth;
    public int AttackSpeed;
    public int AttackDamage;
    public float TurnSpeed = 20f;
    public float AttackCooldown = 0f;
}
