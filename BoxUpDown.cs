using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUpDown : MonoBehaviour
{
    float speed = 5f; // Public breyta sem stj�rnar hra�anum
    float height = 1.0f; // breytir hversu h�tt hluturinn f�rist

    void Update()
    {
        Vector3 pos = transform.position; // Finnur sta�setninguna � hlutnum og setur � breytuna pos
        float newY = Mathf.Sin(Time.time * speed); // Finnur �t hver n�ja sta�setningin fyrir y ver�ur 
        transform.position = new Vector3(pos.x, newY+3, pos.z) * height; // Setur hlutinn � n�ja sta�inn sem y f�kk
    }
}
