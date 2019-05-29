using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{

    [Range( 0, 200 )]
    public int grassDensity = 20;

    private GameObject grassStarter;

    private Transform grassParent;

    private GameObject[] ground;

    // Start is called before the first frame update
    void Start()
    {
        grassStarter = GameObject.Find("Grass");
        grassParent = grassStarter.transform.parent;
        ground = GameObject.FindGameObjectsWithTag("ground");

        Debug.Log("Generating " + grassDensity + " pieces of grass");

        for (int i = 0; i < grassDensity; i++)
        {
            Vector3 newPosition = RandomPosition(grassStarter.transform.position, i);
            grassStarter = Instantiate(grassStarter, newPosition, Quaternion.identity, grassParent);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Called by instantiate to generate a random grass position
    // Should choose a position where:
    //     Y is equal to the top boundary of a ground piece
    //     X is not within a range of another grass piece
    // Taking the position of the last blade of grass and generating
    // a new position that is NOT that should help to keep things
    // distributed
    Vector2 RandomPosition(Vector3 lastPosition, int seed)
    {
        GameObject platform = ground[Random.Range(0, ground.Length)];
        Vector3 platformPosition = platform.transform.position;
        Vector3 platformScale = platform.transform.localScale;
        Debug.Log(platformPosition);
        platformPosition.y += 0.2f;
        platformPosition.x = Random.Range(platformPosition.x - platformScale.x / 2 + 0.1f, platformPosition.x + platformScale.x / 2 - 0.1f);
        return platformPosition;
    }
}
