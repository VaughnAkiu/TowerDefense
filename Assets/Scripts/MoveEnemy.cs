
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;

    //position of enemy, related to waypoints.
    public int position = 0;

    //vector2 stores x and y 
    Vector2 movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision detected");
        if (collision.name == "MoveDown")
        {
            position = 1;
            movement.x = 0;
            movement.y = -1;

        }
        else if (collision.name == "MoveRight")
        {
            position = 2;
            movement.x = 1;
            movement.y = 0;

        }
        else if (collision.name == "MoveLeft")
        {
            position = 3;
            movement.x = -1;
            movement.y = 0;

        }
        else if (collision.name == "MoveUp")
        {
            position = 4;
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
        movement.x = 1;
        movement.y = 0;
        
    }

    private void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        /*
        //starting point
        if (position == 0)
        {
            movement.x = 0;
            movement.y = -1;
        }
        else if (position == 1)
        {
            movement.x = 1;
            movement.y = 0;
        }
        else if (position == 2)
        {
            movement.x = 0;
            movement.y = -1;
        }
        else if (position == 3)
        {
            movement.x = -1;
            movement.y = 0;
        }
        else if (position == 4)
        {
            movement.x = 0;
            movement.y = -1;
        }
        else if (position == 5)
        {
            movement.x = -1;
            movement.y = 0;
        }
        else if (position == 6)
        {
            movement.x = 0;
            movement.y = -1;
        }*/

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        
    }
}
