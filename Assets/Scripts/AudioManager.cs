using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClipType
{
	die,
	point,
	wing
}

public class AudioManager : MonoBehaviour 
{
	public static AudioManager _instance;

	public AudioClip[] allAudioClips;
	public AudioSource audioSourceOths;
	// Use this for initialization
	void Awake () {
		_instance = this;
	}

	public void setAudio (AudioClipType index) {
		audioSourceOths.clip = allAudioClips [(int)index];
		audioSourceOths.Play ();
	}
}
