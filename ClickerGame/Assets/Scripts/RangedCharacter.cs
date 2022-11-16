using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangedCharacter : Character
{
    public RangedCharacterSO CharacterSO;
    public GameObject RangedHitEffect;
    public Image HealthBar;

    private void Start()
    {
        CurrentHealth = CharacterSO.MaxHealth;
        characterType = Character.CharacterType.Ranged;
        CurrentState = CharacterStates.Idle;
    }
}
