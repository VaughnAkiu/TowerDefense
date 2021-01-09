
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    

    //public SceneChange sceneChange;
    //public SoundsMaster soundMaster;

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

            if(PlayerStats.livesRemaining > 0)
            {
                PlayerStats.instance.ChangePlayerLivesText();
            }
            else
            {
                //use game over scene when that is setup
                //sceneChange.GameOver();
                //sceneChange.MainMenu();
                //AudioSource.PlayClipAtPoint(soundMaster.gameOverNoise, transform.position, 0.9f);
                SceneManager.LoadScene("MainMenuScene");
            }
            
            Destroy(gameObject);

        }

    }

    private void Start()
    {
        //trying to use this for slowing effect otherwise unused
        enemy = GetComponent<Enemy>();
        //soundMaster = GetComponent<SoundsMaster>();
        //sceneChange = GetComponent<SceneChange>();

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
