using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Begin : MonoBehaviour // Classinn b�inn til
{
	public Button yourButton; // Public breyta

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>(); // Takki skilgreindur
		btn.onClick.AddListener(Endurr�sa); // Listener settur � takkann. ef a� �tt er � hann �� er kalla� � endurr�sa falli�
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!"); // Debug til a� kanna hvort a� takki virki
	}
	    public void Endurr�sa() // Endurr�sa falli� skilgreint sem fer � n�sta senu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//n�sta sena
    }
}
