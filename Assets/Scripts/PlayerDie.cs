using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour 
{
	public GameObject gameOver;
	// Use this for initialization

	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log ("dshdjsf");
		if (other.gameObject.name == "player") 
		{
			AudioManager._instance.setAudio (AudioClipType.die);
			if (!gameOver.activeSelf) 
			{
				gameOver.SetActive (true);
			}


			MapMove map1 = GameObject.Find ("map1").GetComponent<MapMove>();
			map1.enabled = false;
			MapMove map2 = GameObject.Find ("map2").GetComponent<MapMove>();
			map2.enabled = false;

			Rigidbody2D playerRigidbody2D = GameObject.Find ("player").GetComponent<Rigidbody2D> ();
			Destroy (playerRigidbody2D);
		}
	}
}
