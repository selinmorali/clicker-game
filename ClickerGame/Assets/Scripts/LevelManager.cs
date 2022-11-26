using System.Collections;
using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager>
{
    public int CurrentStage = 1;
    public int CurrentLevel = 1;
    public GameObject SpawnPoint;

    public IEnumerator NextStage()
    {
        yield return new WaitForSeconds(0.9f);
        FadeControl.Instance.PlayFade();
        CurrentStage++;
        yield return new WaitForSeconds(1f);
        Instantiate(LevelInfo.Instance.Level.Enemies[CurrentStage-1], SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        UIManager.Instance.SetText();
    }
}