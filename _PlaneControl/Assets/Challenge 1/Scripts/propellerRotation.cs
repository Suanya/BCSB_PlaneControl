using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerRotation : MonoBehaviour
{
    public float propellerSpeed = 5000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate propeller
        transform.Rotate(0, 0, propellerSpeed * Time.deltaTime);
    }
}
