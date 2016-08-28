using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioSource sfxSource;
	public AudioSource musicSource;
	public static SoundManager instance = null;

	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	public void PlayClip (AudioClip clip)
	{
		sfxSource.clip = clip;
		sfxSource.Play ();
	}
}
