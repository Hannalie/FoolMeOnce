using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] private Transform player;  // Referens till spelaren
    [SerializeField] private float smoothSpeed = 10f;  // Hur snabbt kameran f�ljer
    [SerializeField] private Vector3 offset = new Vector3(-10f, 1f, -10f);  // Justera f�r att f� r�tt position

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        }
    }
}
