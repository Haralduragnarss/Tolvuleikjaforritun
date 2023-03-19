using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound) // Ef að pizzan fer yfir 30 þá eyðist hún
        {
            Destroy(gameObject); // Pizzunni eytt
        }
        else if(transform.position.z < lowerBound) // Ef að dýrin fara neðar enn -10 þá eyðist hún
        {
            Debug.Log("GAME OVER!"); // Game skilaboð
            Destroy(gameObject); // Dýri eytt
        }
    }
}
