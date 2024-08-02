using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    public float minX, maxX;

    private void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + Vector3.right * input * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;
    }
}
