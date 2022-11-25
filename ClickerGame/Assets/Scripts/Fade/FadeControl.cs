using System.Collections;
using UnityEngine;

public class FadeControl : MonoSingleton<FadeControl>
{
    public GameObject FadeCanvas;

    public void PlayFade()
    {
        FadeCanvas.transform.GetChild(0).gameObject.SetActive(true);
        FadeCanvas.GetComponentInChildren<Animation>().Play("FadeAnim");
    }
}
