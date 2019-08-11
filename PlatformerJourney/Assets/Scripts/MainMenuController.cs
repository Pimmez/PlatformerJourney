using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{

	public Button lvl02;
	private int levelPassed;
	[SerializeField] private Sprite lockImage, unlockedImage;
	[SerializeField] private Image lvl2Image;
	[SerializeField] private GameObject menuHolder;

    private void Awake()
    {
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		lvl02.interactable = false;
		lvl2Image.sprite = lockImage;

		switch (levelPassed)
		{
			case 1:
				lvl02.interactable = true;
				lvl2Image.sprite = unlockedImage;
				break;
		}
    }

	public void QuitApplication()
	{
		Application.Quit();
	}

	public void ActivateLevelHolder(bool isActive)
	{
		menuHolder.SetActive(isActive);
	}

	public void LevelToLoad(int level)
	{
		SceneManager.LoadScene(level);
	}

	public void ResetPlayerPrefs()
	{
		lvl02.interactable = false;
		lvl2Image.sprite = lockImage;
		PlayerPrefs.DeleteAll();
	}
}