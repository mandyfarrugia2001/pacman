using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ghost Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject pathPrefab;

    public List<Transform> GetWaypoints() 
    {
        List<Transform> waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
            waveWaypoints.Add(child);
        return waveWaypoints;
    }
}
