using UnityEngine;

[CreateAssetMenu(fileName="Level", menuName = "ScriptableObjects/Level ScriptableObjects", order = 2)]

public class LevelSO : ScriptableObject
{
    public GameObject[] Enemies = new GameObject[10];
}
