using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour 
{
	public float speed = 300f;
	private RectTransform tube1;
	private RectTransform tube2;


	RectTransform _transform;
	// Use this for initialization
	void Awake () {
		_transform = transform as RectTransform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (_transform.anchoredPosition.x <= -761) 
		{
			_transform.anchoredPosition = new Vector2 (761f, 0);
			tube1.anchoredPosition = new Vector2 (tube1.anchoredPosition.x, Random.Range (-130f, 230f));
			tube2.anchoredPosition = new Vector2 (tube2.anchoredPosition.x, Random.Range (-130f, 230f));

		}
	}
}
