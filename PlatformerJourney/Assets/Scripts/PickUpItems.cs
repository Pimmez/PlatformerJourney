using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == Tags.Player && this.gameObject.tag == Tags.Health)
		{
			Player.Instance.Lives++;
			Destroy(this.gameObject);
		}
	}
}