using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn_L1 : MonoBehaviour
{
    private int minY = -3; // Ch�kka hvort a� leikma�urinn datt �taf

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY) // Ef a� leikma�urinn dettur ne�ar en -3
        {
            transform.position = new Vector3(7.75f, 0.8f, -1.68f); // Leikma�urinn respawnar � �essum hnitum
        }
    }
}
