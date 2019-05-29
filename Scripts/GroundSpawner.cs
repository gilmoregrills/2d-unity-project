using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public Vector3 worldDimensions;

    [Range( 0, 200 )]
    public int totalGround;

    private GameObject groundStarter;

    private Transform groundParent;

    // Start is called before the first frame update
    void Start()
    {
        groundStarter = GameObject.Find("Ground");
        groundParent = groundStarter.transform.parent;

        Debug.Log("Generating " + totalGround + "units of ground areas");

        for (int i = 0; i < totalGround; i++)
        {
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Called by instantiate to generate a random ground position
    // Should choose a position where:
    //     Y is equal to the top boundary of a ground piece
    //     X is not within a range of another ground piece
    // Taking the position of the last blade of ground and generating
    // a new position that is NOT that should help to keep things
    // distributed
    Vector2 RandomPosition(Vector3 lastPosition, int seed)
    {
        return "yes";
    }
}
