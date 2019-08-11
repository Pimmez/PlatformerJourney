using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static Player Instance { get { return GetInstance(); } }

	#region Singleton

	private static Player instance;

	private static Player GetInstance()
	{
		if (instance == null)
		{
			instance = FindObjectOfType<Player>();
		}
		return instance;
	}

	#endregion

	public int Lives { get { return lives; } set { lives = value; } }
	public int MaxLives { get { return maxLives; } }
	public Vector3 Position { get { return position; } set { position = value; } }

	private Vector3 position;
	private int maxLives = 5;
	private int lives;

	private Animator anim;
	
	private void Start()
	{
		anim = GetComponent<Animator>();
		lives = maxLives;
	}

	private void Update()
	{
		UpdateLives();
	}

	private void UpdateLives()
	{
		if (lives == 0)
		{
			Destroy(gameObject);
			LevelController.Instance.loseHolder.SetActive(true);
		}

		if(lives >= maxLives)
		{
			lives = maxLives;
		}
	}
}