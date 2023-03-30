
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Breyta sem tekur inn player-inn sem target til að elta
    public float smoothSpeed = 0.125f; // Hraðinn á myndavélinni settur
    public Vector3 offset; // Breyta til að stilla x-ið

    void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; // Staðurinn sem við viljum að mynda einbeiti sér að er fundinn
        Vector3 smoothPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed); // hreyfingin á myndavélinni(hvernig hún eltir hlutinn)
        transform.position = smoothPosition; // Hreyfingin á vélinni.
    }
}
