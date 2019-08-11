using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
	private Animator anim;
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == Tags.Player)
		{
			anim.SetBool("Flaggin", true);
			audioManager.PlayAudioOnce(2);
			LevelController.Instance.winHolder.SetActive(true);
		}
	}
}
