using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public int Lives { get { return lives; } set { lives = value; } }

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