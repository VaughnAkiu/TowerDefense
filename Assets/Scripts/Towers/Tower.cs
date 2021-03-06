using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{
    [Header("Attributes")] //edit within Unity
    public Transform target;
    public float range = 1f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public int goldCost;
    public int upgradeCost;
    public string towerTitle;
    public string towerDescription;

    // AudioSource audioSource;
    public AudioClip shootNoise;

    //scriptables
    //going to have to recode this wonkyness
    private static string towerTitleStatic;


    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    public GameObject projectilePreFab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        //watch out for using alot of these
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        //audioSource = GetComponent<AudioSource>();

    }

    //check every definied amount of time for targets
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;


        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
            
        }
        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject projectileGameObject = (GameObject)Instantiate(projectilePreFab, firePoint.position, firePoint.rotation);
        Projectile projectile = projectileGameObject.GetComponent<Projectile>();
        //audioSource.PlayOneShot(shootNoise, 0.5f);
        AudioSource.PlayClipAtPoint(shootNoise, transform.position, 0.5F);

        if (projectile != null)
        {
            projectile.Seek(target);
        }
    }


    //turret range indicator
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
