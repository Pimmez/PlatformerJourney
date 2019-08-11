using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
	public static LevelController Instance { get { return GetInstance(); } }

	#region Singleton

	private static LevelController instance;

	private static LevelController GetInstance()
	{
		if (instance == null)
		{
			instance = FindObjectOfType<LevelController>();
		}
		return instance;
	}

	#endregion

	public GameObject hudHolder, loseHolder, winHolder;
	private int levelPassed;
	private int sceneIndex;
	private bool isHUDActive = false;

	// Start is called before the first frame update
	private void Awake()
    {
		loseHolder.SetActive(false);
		hudHolder.SetActive(false);
		winHolder.SetActive(false);

		sceneIndex = SceneManager.GetActiveScene().buildIndex;
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isHUDActive = !isHUDActive;
			hudHolder.SetActive(isHUDActive);
			if(isHUDActive)
			{
				Time.timeScale = 0;
			}
			else
			{
				Time.timeScale = 1;
			}
		}
	}

	public void LevelCompleted()
	{
		if(levelPassed < sceneIndex)
		{
			PlayerPrefs.SetInt("LevelPassed", sceneIndex);
		}

		SceneManager.LoadScene(sceneIndex + 1);
	}

	public void GoToScene(int level)
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(level);
	}

	public void RestartLevel()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(sceneIndex);
	}

	public void HUDHolder()
	{
		hudHolder.SetActive(false);
		Time.timeScale = 1;
	}
}
