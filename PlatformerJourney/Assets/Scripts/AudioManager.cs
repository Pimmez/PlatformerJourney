using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
	[SerializeField] private AudioSource audioSource;
	[SerializeField] private List<AudioClip> clips = new List<AudioClip>();

	public void PlayAudioOnce(int numberOfClip)
	{
		audioSource.PlayOneShot(clips[numberOfClip]);
	}

	public void PlayAudioOnlyOnce(int numberOfClip)
	{
		if (!audioSource.isPlaying)
		{
			audioSource.PlayOneShot(clips[numberOfClip]);
		}
		else
		{
			return;
		}
	}
}