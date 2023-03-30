using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI count_Text; // Breyta fyrir textann 
    float speed = 0.2f; // Hraði settur
    float sideways = 0.2f; // Hraði til hliða settur
    float jump = 0.1f; // Hæð sem leikmaður stekkur
    public static int count = 0; // ekki notað
    //public Text countText;
    private int score; // Stiginn hjá leikmanninum
    //private Rigidbody leikmadur;
    public int minY = -3; // Hæð til að sjá hvort hann datt útaf
                          // 

    void Start()
    {
        Debug.Log("byrja");
        score = 1; // Leikmaður byrjar með eitt stig 
        SetCountText(); // Stiginn hjá honum í byrjun sýnd
    }

    void SetCountText()
    {
        count_Text.text = "Peningar: " + score.ToString(); // Skilar stigum(peningum) leikmanns á skjáinn
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY) // Ef að leilkmaðurinn dettur af borðinu neðar enn -3 þá respawnast hann frá byrjun
        {
            transform.position = new Vector3(7.75f, 0.8f, 44.8f); // Staðurinn sem hann respawnast er settur
           
        }
        if (score <= 0) // Ef að leikmaðurinn missir alla peningana sína 
        {
            SceneManager.LoadScene(4); // Kallað er á gameOver senuna
        }

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))//�fram
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))// til baka 
        {
            transform.position += -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))//h�gri
        {
            transform.position += transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//vinstri
        {
            //hreyfir player um sideways � hvert skipti sem �tt er � leftArrow
            transform.position += -transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.Space))//hoppa
        {
            transform.position += transform.up * jump;
        }
        //sn� player
        if (Input.GetKey("f"))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
        if (Input.GetKey("g"))//sn�a leikmanni
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }
    
        if (Input.GetKey("q"))
        {
            Debug.Log("h�h�");
            transform.SetPositionAndRotation(new Vector3(transform.position.x, 1, transform.position.z),Quaternion.identity);
        }
        
    }

    private void OnCollisionEnter(Collision other) // Til að collect peninginn finnur collisionið
    {
        if (other.gameObject.CompareTag("Pickup")) // Ef að leikmaðurinn klessir á pening
        {
            other.gameObject.SetActive(false); // Hluturinn hverfur
            score = score + 1; // Leikmaðurinn fær stig bætt við sig
            SetCountText(); // Nýja stigið hjá leikmaninu er sýnt
        }
        if (other.gameObject.CompareTag("Enemy")) // Ef að leikmaður klessir á "óvin"
        {
            score = score - 1; // Leikmaður missir stig
            SetCountText(); // Nýja stigið hjá player er sýnt
        }

    }

 



}