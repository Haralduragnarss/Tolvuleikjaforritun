using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
	public Button yourButton; // Public breyta fyrir takkann, takkinn setur inn í breytina

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>(); // Takkinn skilgreindur
		btn.onClick.AddListener(Endurræsa); // Listener settur á takkann til að virka þegar ýtt er á hann, kallar svo á endurræsa fallið
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!"); // Debug til að sjá hvort að hann virki
	}
	    public void Endurræsa() // Endurræsa fallið kallar á senu 1
    {
        SceneManager.LoadScene(1);//næsta sena
    }
}
