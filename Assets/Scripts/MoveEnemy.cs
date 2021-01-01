
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;

    private Transform target;
    private int waypointIndex = 0;

    private void Start()
    {
        target = Waypoints.waypoints[0];
            
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }

}
