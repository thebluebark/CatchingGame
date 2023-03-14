using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Array to hold our fish
    public GameObject fish;

    //Variable to hold our bomb
    public GameObject bomb;

    //Hold possible places for the droppables to spawn
    public float horizontalBounds, verticalHeight;

    //Control how fast we want to drop these things in seconds
    public float spawnMinTime = 1.0f;
    public float spawnMaxTime = 2.0f;

    //Control the rate for dropping a bomb
    public float bombChance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        //Start our SpawnDropables coroutine
        StartCoroutine(SpawnDropables());
    }

    //Coroutine to spawn our dropables
    public IEnumerator SpawnDropables()
    {
        //Start an endless loop
        while (true)
        {
            //Wait for a random amount of time within our range
            yield return new WaitForSeconds(Random.Range(spawnMinTime, spawnMaxTime));

            //Select a random position for this potential drop to spawn in
            float xPos = Random.Range(-horizontalBounds, horizontalBounds);
            Vector2 spawnPos = new Vector2(xPos, verticalHeight);

            //Now we choose on whether we want to drop a fish or bomb by change
            if (Random.value >= bombChance)
            {
                //Drop a fish

                //Instantiate/clone the fish
                Instantiate(fish, spawnPos, Quaternion.identity);

            }
            else
            {
                //Drop a bomb

                //Instantiate/clone the bomb
                Instantiate(bomb, spawnPos, Quaternion.identity);
            }
        }
    }
}
