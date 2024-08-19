using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();

    void Start()
    {
        var spawnPointGroup = GameObject.Find("SpawnPointGroup");
        spawnPointGroup.GetComponentsInChildren<Transform>(points);
    }

}
