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
    private void OnTriggerEnter(Collider other) // Ef a� leikma�urinn fer � triggerinn til a� skipta um senu
    {
        other.gameObject.SetActive(false); 
        StartCoroutine(Bida()); // Kalla� � falli� sem l�tur load-i� b��a � tv�r sek
    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(2); // L�tur allt b��a � 2 sek
        Endurr�sa(); // Kalla� � endurr�sa falli�
    }
    public void Endurr�sa() // Kallar � n�stu senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//n�sta sena
    }

}