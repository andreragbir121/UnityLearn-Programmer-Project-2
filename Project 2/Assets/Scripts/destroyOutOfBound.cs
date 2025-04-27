using UnityEngine;

public class destroyOutOfBound : MonoBehaviour
{
    private float topBound = 30;        //variable for the top bound of the game. Top part of the scene
    private float lowerBound = -10;    //variable for the lower bound of the game. bottom part of the scene
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound){               //if the position z is more than the value of the top bound then:
            Destroy(gameObject);                            //destroy the game object
            Debug.Log("GAME OVER, COLLISION DETECTED");     //output the string text
        } else if (transform.position.z < lowerBound){      //else if the position z is less than the lower bound:
            Destroy(gameObject);                            //destroy the game object
        }
    }
}