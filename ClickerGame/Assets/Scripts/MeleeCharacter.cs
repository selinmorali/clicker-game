using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeCharacter : Character
{
    public MeleeCharacterSO CharacterSO;
    public GameObject MeleeHitEffect;
    public Image HealthBar;

    public bool IsBoardCleared = false; //gamemanager isi
    //public GameObject SpellPrefab; //resources'tan eriþ
    //private string winnerSide = ""; //gamemanager isi
    //private GameObject[] _enemies; //gamemanager isi
    //private GameObject[] _heroes; //gamemanager isi

    void Start()
    {
        CurrentHealth = CharacterSO.MaxHealth;
        characterType = Character.CharacterType.Melee;
        CurrentState = CharacterStates.Idle;
    }
}
