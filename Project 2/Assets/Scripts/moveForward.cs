using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 10;    //variable for the speed of the object
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes the object move forward with the above speed variable 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
