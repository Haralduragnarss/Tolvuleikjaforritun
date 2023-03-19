using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DetectCollision : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    void SetCountText()
	{
		countText.text = "Stig: " + count.ToString();
	}
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Pizzan eyðist ef hún snetir dýr
        Destroy(other.gameObject); // Dýri eytt ef pizzan snertir hana
        count = count + 1; // teljarinn bætir við sitg
        Debug.Log("Stig: " + count); // Game skilaboð
        SetCountText();

    }
}
