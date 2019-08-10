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

	private int maxLives = 5;
	private int lives;
	
	private void Start()
	{
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
			//Destroy(this.gameObject);
		}

		if(lives >= maxLives)
		{
			lives = maxLives;
		}
	}
}