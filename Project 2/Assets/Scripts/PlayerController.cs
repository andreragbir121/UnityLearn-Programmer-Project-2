using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;       //variable for the horizontal input value
    public Vector3 movement = new Vector3(0, 1, 0);     //vector3 for assigning the coordinates
    public float speed =10f; //speed variable for get the speed of the object

    private float xRange = 15;  //variable for assigning the value of the xrange

    public GameObject food;     //gameobject variable for the assigning food objects.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //keep players inbound
        if (transform.position.x < -xRange)                 //if the position of object is less than -xRange  then 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);  //set the position of the the values in above declared variables so that the player does not move out the screen
        }

        //keep players inbound
       if (transform.position.x > 15)  //if the x position is more than 15 then 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);  ///set the position of the the values in above declared variables so that the player does not move out the screen
        }


        //gets horizontal input from unity and move player
        horizontalInput = Input.GetAxis("Horizontal");    //uses the horizontalInput variable declared to get the input access from user 
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);      //uses the vector3.right * horizontalInput * Time.deltaTime * speed  to move the player left or right


        if (Input.GetKeyDown(KeyCode.Space)){           //gets the key input pressed by player and:
            Instantiate(food, transform.position, food.transform.rotation); //continuously spawns object/food from player

        }
    }
}
