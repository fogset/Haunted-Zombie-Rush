using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField]
    private float ObjectSpeed = 1;

    [SerializeField]
    private float resetPosition = -21.65f;

    [SerializeField]
    private float startPosition = 58f;

    void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!GameManager.instance.GameOver)
        {
            transform.Translate(Vector3.left * (ObjectSpeed * Time.deltaTime));
            if (transform.localPosition.x <= resetPosition)
            {
                Vector3 newPos =
                    new Vector3(startPosition,
                        transform.position.y,
                        transform.position.z);
                transform.position = newPos;
            }
        }
    }
}
