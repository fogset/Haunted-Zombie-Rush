using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField]
    private float ObjectSpeed = 1;

    private float resetPosition = -21.65f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * (ObjectSpeed * Time.deltaTime));
        if (transform.localPosition.x <= resetPosition)
        {
            Vector3 newPos =
                new Vector3(58f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
