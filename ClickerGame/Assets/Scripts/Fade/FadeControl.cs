using UnityEngine;

public class FadeControl : MonoSingleton<FadeControl>
{
    public GameObject Canvas;

    public void PlayFade()
    {
        Canvas.transform.GetChild(0).gameObject.SetActive(true);
        Canvas.GetComponentInChildren<Animation>().Play("FadeAnim");
    }
}
