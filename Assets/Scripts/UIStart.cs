using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIStart : MonoBehaviour 
{
	public GameObject panel_start;
	public GameObject panel_rate;
	public GameObject panel_rank;
	public Text score;
	public Text maxscore;


	public void clickOpenPanel_Rate()
	{
		Debug.Log ("click start");
		if (!panel_rate.activeSelf) 
		{
			panel_rate.SetActive (true);
		}
		if(panel_start.activeSelf)
		{
			panel_start.SetActive (false);
		}
	}

	public void clickOpenPanel_Rank()
	{
		score.text = GameServer.getSingleTon ().score.ToString();
		maxscore.text = GameServer.getSingleTon ().maxscore.ToString();
		Debug.Log ("click Rank");
		if (!panel_rank.activeSelf) 
		{
			panel_rank.SetActive (true);
		}
		if(panel_start.activeSelf)
		{
			panel_start.SetActive (false);
		}
	}

	public void clickClosePanel_Rank()
	{
		if (panel_rank.activeSelf) 
		{
			panel_rank.SetActive (false);
		}
		if(!panel_start.activeSelf)
		{
			panel_start.SetActive (true);
		}
	}

	public void ClickStartGame()
	{
		GameServer.getSingleTon ().resetScore ();
		SceneManager.LoadScene ("Main");
	}
}
