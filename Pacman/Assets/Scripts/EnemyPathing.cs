using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] WaveConfig waveConfig;
    [SerializeField] float movementSpeed = 30f;
    List<Transform> waypoints = new List<Transform>();
    int waypointIndex = 0;

    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update() => MoveEnemy();

    void MoveEnemy()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            Vector3 targetPosition = waypoints[waypointIndex].transform.position;
            float movementDelta = Time.deltaTime * movementSpeed;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementDelta);

            if (transform.position == targetPosition)
                waypointIndex++;
        }
        else
            waypointIndex = 1;
    }
}
