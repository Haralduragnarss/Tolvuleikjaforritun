using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUpDown : MonoBehaviour
{
    float speed = 5f; // Public breyta sem stjórnar hraðanum
    float height = 1.0f; // breytir hversu hátt hluturinn færist

    void Update()
    {
        Vector3 pos = transform.position; // Finnur staðsetninguna á hlutnum og setur í breytuna pos
        float newY = Mathf.Sin(Time.time * speed); // Finnur út hver nýja staðsetningin fyrir y verður 
        transform.position = new Vector3(pos.x, newY+3, pos.z) * height; // Setur hlutinn á nýja staðinn sem y fékk
    }
}
