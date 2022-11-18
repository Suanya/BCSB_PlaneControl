using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    // private Vector3 offset = new Vector3(-100, 0, 50);

    // vonVorne
    // private Vector3 offset = new Vector3(0, 3, 8);

    // vonHinten
    private Vector3 offset = new Vector3(2, 3, -10);

    // durchDieMitte
    // private Vector3 offset = new Vector3(0, 1.88f, 0.44f);

    // Start is called before the first frame update
    /*
    void Start()
    {

    }
    */

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
