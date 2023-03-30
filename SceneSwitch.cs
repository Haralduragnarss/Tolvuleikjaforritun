using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    void Start()
    {
        Debug.Log("byrja");
    }
    private void OnTriggerEnter(Collider other) // Ef að leikmaðurinn fer í triggerinn til að skipta um senu
    {
        other.gameObject.SetActive(false); 
        StartCoroutine(Bida()); // Kallað á fallið sem lætur load-ið bíða í tvær sek
    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(2); // Lætur allt bíða í 2 sek
        Endurræsa(); // Kallað á endurræsa fallið
    }
    public void Endurræsa() // Kallar á næstu senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//næsta sena
    }

}