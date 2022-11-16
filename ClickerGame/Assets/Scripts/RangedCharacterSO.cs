using UnityEngine;

[CreateAssetMenu(fileName = "RangedCharacter", menuName = "ScriptableObjects/Ranged Character Scriptable Object", order = 2)]
public class RangedCharacterSO : ScriptableObject
{
    public int MaxHealth;
    public int AttackSpeed;
    public int AttackDamage;
    public float TurnSpeed = 20f;
    public float AttackCooldown = 0f;
    public Transform FirePoint;
    public Transform HitPoint;
}
