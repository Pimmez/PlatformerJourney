using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI timer;
	[SerializeField] private float timeLeft = 120;
	private int min;
	private int sec;
	[SerializeField] private GameObject player;
	private AudioManager audioManager;

	// Start is called before the first frame update
	private void Start()
    {
		audioManager = FindObjectOfType<AudioManager>();
		min = Mathf.FloorToInt(timeLeft / 60);
		sec = Mathf.FloorToInt(timeLeft % 60);

		timer.text = min.ToString("00" + ":" + sec.ToString("00"));
	}

	private void Update()
    {
		min = Mathf.FloorToInt(timeLeft / 60);
		sec = Mathf.FloorToInt(timeLeft % 60);
		timer.text = min.ToString("00") + ":" + sec.ToString("00");
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			timer.text = "00:00";
			audioManager.PlayAudioOnce(6);
			LevelController.Instance.loseHolder.SetActive(true);
			Destroy(player);
		}
	}
}
