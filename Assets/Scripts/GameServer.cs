using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameServer  {

	private static GameServer _instance;

	public static GameServer getSingleTon()
	{
		if (_instance == null) {
			_instance = new GameServer ();
		}
		return _instance;
	}

	private GameServer()
	{
		score = 0;
		maxscore = 0;
	}

	public void setMaxScore()
	{
		if (score > maxscore) {
			maxscore = score;
		}
	}

	public void resetScore()
	{
		score = 0;
	}

	public float score;
	public float maxscore;
}
