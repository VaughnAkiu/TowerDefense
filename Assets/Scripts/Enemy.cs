using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startingHealth = 10;
    public float startSpeed;
    public float speed;
    //gold rewarded
    public int gold;

    private float health;

    [Header("Unity Stuff")]
    public Image healthBar;
    public Text healthBarText;
    

    private bool isDead = false;
    //public GameObject deathEffect;


    private void Start()
    {
        speed = startSpeed;
        health = startingHealth;
    }

    public void TakeDamage (float amount)
    {
        health -= amount;
        //fill amount related to healthBar (Image)
        healthBar.fillAmount = health / startingHealth;
        healthBarText.text = health + "/" + startingHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }

    }

    public void Slow (float percent)
    {
        speed = startSpeed * (1f - percent);
    }




    void Die()
    {
        isDead = true;
        //increase player money when mob dies
        PlayerStats.gold = PlayerStats.gold + gold;
        PlayerStats.instance.ChangeGoldText();

        //increase kill count
        PlayerStats.mobKills++;
        PlayerStats.instance.ChangeKillCountText();
        //play death effect (instantiate one)
        //destroy death effect after time Destroy(effect, 5f)

        //destroys gameObject which belongs to this script.
        Destroy(gameObject);

    }

}
