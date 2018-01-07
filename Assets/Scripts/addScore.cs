using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "player") {
			//
			GameServer.getSingleTon().score++;
			AudioManager._instance.setAudio (AudioClipType.point);
			GameServer.getSingleTon ().setMaxScore ();
		}

	}
}
