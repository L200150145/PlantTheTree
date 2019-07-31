using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    public float speed = 3.5f;
    private float gravity = 10f;

    CharacterController controller;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKeyDown)
            Debug.Log(Input.inputString);

        PlayerMovement();

        if (controller.isGrounded == true && controller.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        } else if (controller.isGrounded == true && controller.velocity.magnitude == 0f && GetComponent<AudioSource>().isPlaying == true)
        {
            GetComponent<AudioSource>().Stop();
        }

	}

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }

}
