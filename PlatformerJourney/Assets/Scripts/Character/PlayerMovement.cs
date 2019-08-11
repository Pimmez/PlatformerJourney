using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private CharacterController2D controller;
	[SerializeField] private float runSpeed = 40f;
	private float horizontalMove = 0f;
	private bool jump = false;

	private Animator anim;
	private AudioManager audioManager;

	private void Start()
	{
		anim = GetComponent<Animator>();
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void Update()
    {
		horizontalMove	= Input.GetAxisRaw("Horizontal") * runSpeed;

		if(horizontalMove > 0)
		{
			anim.SetBool("isWalking", true);
		}
		else if(horizontalMove < 0)
		{
			FlipPlayer(true);
			anim.SetBool("isWalking", true);
		}
		else
		{
			anim.SetBool("isWalking", false);
		}

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			audioManager.PlayAudioOnce(1);
		}
	}

	private void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

	private void FlipPlayer(bool isFlipped)
	{
		if (isFlipped)
		{
			transform.localScale = new Vector3(-1, 1, 1);  //face left
		}
		else
		{
			transform.localScale = new Vector3(1, 1, 1);  //face right
		}
	}
}