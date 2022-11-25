using System.Collections;
using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager>
{
    public int CurrentStage = 1;
    public int CurrentLevel = 1;

    public void NextStage()
    {
        StartCoroutine(WaitTwoSeconds());
        FadeControl.Instance.PlayFade();
        CurrentStage++;
    }
    public IEnumerator WaitTwoSeconds()
    {
        yield return new WaitForSeconds(5f);
    }
}