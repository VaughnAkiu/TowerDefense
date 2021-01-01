
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;

    //position of enemy, related to waypoints.
    public int position = 0;

    //vector2 stores x and y 
    Vector2 movement;
    


    private void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        if (position == 0)
        {
            movement.x = 1;
            movement.y = 0;
        }
        else if (position == 1)
        {
            movement.x = 0;
            movement.y = 1;
        }
        
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
