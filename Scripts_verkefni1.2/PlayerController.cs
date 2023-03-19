using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -20) // Leikmaðurinn kemst ekki lengar enn -15
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > 20) // Leikmaðurinn kemst ekki lengar enn 15
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal"); // Input til að hreyfa kallinn fengið
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // Hreyfingin á sér stað

        if(Input.GetKeyDown(KeyCode.Space)) // Input fengið til að skjóta pizzunni
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
