using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float nextPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnBecameInvisible()
    {
        //Debug.Log("Invisible!");
        transform.position = new Vector3(
            transform.position.x + nextPosition, transform.position.y, 0);
    }
}
