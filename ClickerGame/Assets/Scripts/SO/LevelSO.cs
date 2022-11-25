using UnityEngine;

[CreateAssetMenu(fileName="Level", menuName = "ScriptableObjects/Level ScriptableObjects", order = 2)]
public class LevelSO : ScriptableObject
{
    [Header("Stage Info")]
    public GameObject[] Enemies = new GameObject[10];
}
