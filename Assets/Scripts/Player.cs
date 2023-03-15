using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 100f;

    [SerializeField]
    private AudioClip sfxJump;

    private Animator anim;

    private Rigidbody rigidbody;

    private bool jump = false;

    private AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("Jump");
            audioSource.PlayOneShot (sfxJump);
            rigidbody.useGravity = true;
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump == true)
        {
            jump = false;
            rigidbody.velocity = new Vector2(0, 0);
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
        }

        print(rigidbody.velocity.y);
    }
}
