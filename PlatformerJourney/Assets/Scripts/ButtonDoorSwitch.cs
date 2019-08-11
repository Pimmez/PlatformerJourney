using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorSwitch : MonoBehaviour
{

	[SerializeField] private Sprite switchSprite, doorSprite, doorsprite2;
	[SerializeField] private SpriteRenderer sRenSwitch, sRenDoor, sRenDoor2;
	private AudioManager audioManager;
	[SerializeField] private Collider2D col;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			sRenSwitch.sprite = switchSprite;
			sRenDoor.sprite = doorSprite;
			sRenDoor2.sprite = doorsprite2;
			col.enabled = false;
			audioManager.PlayAudioOnce(0);
		}
	}
}
