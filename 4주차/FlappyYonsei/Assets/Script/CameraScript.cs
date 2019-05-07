using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float smoothTime;
    private Vector3 velocity;
    private float yMax = 1.0f;
    private float yMin = -1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.position;

        // Define a target position above and behind the target transform
        //Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));
        Vector3 targetPos = new Vector3(target.position.x, Mathf.Clamp(target.position.y, yMin, yMax), -10);

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
