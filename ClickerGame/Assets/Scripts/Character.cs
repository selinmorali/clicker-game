using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Character: MonoBehaviour
{
    public enum CharacterType
    {
        Melee,
        Ranged
    }
    public CharacterType characterType;

    public enum CharacterStates
    {
        Idle,
        Fight,
        Death
    };
    public CharacterStates CurrentState;

    GameObject nearestTarget = null;
    public Transform LockedTarget; //?
    public float CurrentHealth;   
}
