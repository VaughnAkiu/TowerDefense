
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;

    public float speed = 25f;
    public GameObject impactEffect;


    public void Seek (Transform _target)
    {
        target = _target;
    }



    // Update is called once per frame
    void Update()
    {

     if (target == null)
     {
        Destroy(gameObject);
        return;
     }

        Vector2 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget ()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 0.5f);

        Destroy(gameObject);
    
    }

}
