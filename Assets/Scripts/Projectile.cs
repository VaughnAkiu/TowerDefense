
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;

    public float speed = 25f;
    public int damage = 2;
    public float slowPercent = 0f;

    public GameObject impactEffect;

    public void Seek (Transform _target)
    {
        target = _target;
    }

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
        //transform.LookAt(target);
    }

    void HitTarget ()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 0.5f);

        Damage(target);
        //based on slow percent of the projectile
        Slow(target, slowPercent);
        

        //if target is dead can destroy target.gameObject
        //Destroy(target.gameObject);
        Destroy(gameObject);
    
    }


    void Damage (Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        //if gameObject exists takedamage
        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }

    void Slow (Transform enemy, float slowPercentAmount)
    {
      

        Enemy e = enemy.GetComponent<Enemy>();

        if (e != null)
        {
            e.Slow(slowPercentAmount);
        }
    }
}
