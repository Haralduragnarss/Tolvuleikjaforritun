using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
	public Button yourButton; // Public breyta fyrir takkann, takkinn setur inn � breytina

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>(); // Takkinn skilgreindur
		btn.onClick.AddListener(Endurr�sa); // Listener settur � takkann til a� virka �egar �tt er � hann, kallar svo � endurr�sa falli�
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!"); // Debug til a� sj� hvort a� hann virki
	}
	    public void Endurr�sa() // Endurr�sa falli� kallar � senu 1
    {
        SceneManager.LoadScene(1);//n�sta sena
    }
}
