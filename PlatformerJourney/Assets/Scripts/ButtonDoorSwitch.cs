using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorSwitch : MonoBehaviour
{

	[SerializeField] private Sprite switchSprite, doorSprite;
	[SerializeField] private SpriteRenderer sRenSwitch, sRenDoor;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == Tags.Player)
		{
			sRenSwitch.sprite = switchSprite;
			sRenDoor.sprite = doorSprite;
		}
	}
}
