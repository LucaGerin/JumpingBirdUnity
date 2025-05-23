using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Reference to the rigid body of the object
    public Rigidbody2D myRigidbody;
    //Upwards velocity of the bird
    public float flapStrength;

    public LogicScript logic;

    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        if (myRigidbody == null)
        {
            myRigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive==true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
