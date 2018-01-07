using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour {

	public Text score;
	
	// Update is called once per frame
	void Update () {
		score.text = GameServer.getSingleTon ().score.ToString ();
	}

	public void clickBack()
	{
		SceneManager.LoadScene ("fffffff");
	}
}
