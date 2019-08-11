using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == Tags.Player)
		{
			Player.Instance.Lives -= 1;
			audioManager.PlayAudioOnce(4);
			collision.gameObject.transform.position = new Vector2(-1.5f, -1.25f);
		}
	}
}
