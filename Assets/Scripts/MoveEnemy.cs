
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;

    //trying to use this as slowing effect otherwise unused
    private Enemy enemy;

    //position of enemy, related to waypoints.
    //private int position = 0;

    //vector2 stores x and y 
    Vector2 movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision detected");
        if (collision.name == "MoveDown")
        {
            //position = 1;
            movement.x = 0;
            movement.y = -1;

        }
        else if (collision.name == "MoveRight")
        {
            //position = 2;
            movement.x = 1;
            movement.y = 0;

        }
        else if (collision.name == "MoveLeft")
        {
            //position = 3;
            movement.x = -1;
            movement.y = 0;

        }
        else if (collision.name == "MoveUp")
        {
            //position = 4;
            movement.x = 0;
            movement.y = 1;

        }
        else if (collision.name == "Endpoint")
        {
            PlayerStats.livesRemaining--;
            PlayerStats.instance.ChangePlayerLivesText();
            Destroy(gameObject);

        }

    }

    private void Start()
    {
        //trying to use this for slowing effect otherwise unused
        enemy = GetComponent<Enemy>();

        movement.x = 1;
        movement.y = 0;
        
    }

    private void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        speed = enemy.speed;     
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        
    }
}
