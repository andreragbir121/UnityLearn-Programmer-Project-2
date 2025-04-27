using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    public GameObject [] animalPrefabs;     //array for storing animal objects in game 

    private int spawnRangeX = 20;
    private int spawnPosZ = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", 1.5f, 1);  //InvokeRepeating allows the game to repeat a process, based on the method call, which is getRandomAnimal, and begins after 1.5 seconds in game and repeats every 1 second
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function for spawning animals:
    void spawnRandomAnimal(){
         int animalIndex = Random.Range(0,animalPrefabs.Length);         //creates an int for the amount of animals within the game, which is chosen between 0 or 3 in the array of animals
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPosZ);     //uses vector3 variable for setting the position that animals spawn

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);       //instantiate objects a given position and rate based on the variables declared
    }
}
