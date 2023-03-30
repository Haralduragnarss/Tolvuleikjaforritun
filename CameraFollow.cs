
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Breyta sem tekur inn player-inn sem target til a� elta
    public float smoothSpeed = 0.125f; // Hra�inn � myndav�linni settur
    public Vector3 offset; // Breyta til a� stilla x-i�

    void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; // Sta�urinn sem vi� viljum a� mynda einbeiti s�r a� er fundinn
        Vector3 smoothPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed); // hreyfingin � myndav�linni(hvernig h�n eltir hlutinn)
        transform.position = smoothPosition; // Hreyfingin � v�linni.
    }
}
