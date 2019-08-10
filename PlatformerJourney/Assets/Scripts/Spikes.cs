using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == Tags.Player)
		{
			collision.gameObject.transform.position = new Vector2(-1.5f, -1.25f);
			Player.Instance.Lives -= 1;
		}
	}
}
