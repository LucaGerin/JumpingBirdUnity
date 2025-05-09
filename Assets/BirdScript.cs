using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Reference to the rigid body of the object
    public Rigidbody2D myRigidbody;
    //Upwards velocity of the bird
    public float flapStrength;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (myRigidbody == null)
        {
            myRigidbody = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }
}
