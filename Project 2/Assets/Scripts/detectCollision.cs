using UnityEngine;

public class detectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method for detecting when a collider collides with another
    //once on trigger is detected the game object will be destroyed
    void OnTriggerEnter(Collider other)         
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
