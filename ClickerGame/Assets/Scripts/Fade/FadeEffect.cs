using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    public Color FirstColor;
    public Color LastColor;
    public float TimeEffect;
    public float Speed;

    private void OnEnable()
    {
        Speed = 1 / TimeEffect;
    }
}
