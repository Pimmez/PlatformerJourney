using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
	[SerializeField] private GameObject otherPortal;
	[SerializeField] private GameObject target;
	[SerializeField] private float distance = 0.5f;
	[SerializeField] private float warpTimer = 1f;
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == Tags.Player)
		{
			if (Vector2.Distance(transform.position, target.transform.position) > distance)
			{
				StartCoroutine("PortalTime");
			}
		}
		else
		{
			StopCoroutine("PortalTime");
		}
	}

	private IEnumerator PortalTime()
	{
		audioManager.PlayAudioOnce(5);
		yield return new WaitForSeconds(warpTimer);
		target.transform.position = new Vector2(otherPortal.transform.position.x, otherPortal.transform.position.y);
	}
}