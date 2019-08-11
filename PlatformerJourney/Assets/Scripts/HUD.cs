using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
	[SerializeField] private List<Image> heartSprites = new List<Image>();
	[SerializeField] private Sprite fullHeart;
	[SerializeField] private Sprite emptyHeart;

    private void Update()
	{ 
		for (int i = 0; i < heartSprites.Count; i++)
		{
			if(i < Player.Instance.Lives)
			{
				heartSprites[i].sprite = fullHeart;
			}
			else
			{
				heartSprites[i].sprite = emptyHeart;
			}

			if(i < Player.Instance.MaxLives)
			{
				heartSprites[i].enabled = true;
			}
			else
			{
				heartSprites[i].enabled = false;
			}
		}
	}
}