using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

	[SerializeField] private float speed;
	[SerializeField] private Transform point1, point2;
	private float distance;
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void Update()
    {
		transform.Translate(Vector2.right * speed * Time.deltaTime);

		if (gameObject.transform.position.x <= point1.position.x)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (gameObject.transform.position.x >= point2.position.x)
		{
			transform.eulerAngles = new Vector3(0, -180, 0);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == Tags.Player)
		{
			Player.Instance.Lives--;
			audioManager.PlayAudioOnce(4);
			collision.gameObject.transform.position = new Vector2(-1.5f, -1.25f);
		}
	}
}
