using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == Tags.Player && this.gameObject.tag == Tags.Health)
		{
			Player.Instance.Lives++;
			audioManager.PlayAudioOnce(3);
			Destroy(this.gameObject);
		}
	}
}