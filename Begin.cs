using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Begin : MonoBehaviour // Classinn búinn til
{
	public Button yourButton; // Public breyta

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>(); // Takki skilgreindur
		btn.onClick.AddListener(Endurræsa); // Listener settur á takkann. ef að ýtt er á hann þá er kallað á endurræsa fallið
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!"); // Debug til að kanna hvort að takki virki
	}
	    public void Endurræsa() // Endurræsa fallið skilgreint sem fer í næsta senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//næsta sena
    }
}
