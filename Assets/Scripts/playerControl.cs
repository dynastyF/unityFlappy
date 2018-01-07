using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour 
{
	public float speed = 300f;
	private Rigidbody2D _rigidbody;
	private AudioSource audiosce;
	// Use this for initialization
	void Awake () 
	{
		_rigidbody = GetComponent<Rigidbody2D> ();
		audiosce = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (_rigidbody == null)
			return;
		if (Input.GetMouseButtonDown (0)) 
		{
			audiosce.Play ();
			_rigidbody.velocity = new Vector2 (0,speed);
		}

		if(_rigidbody.velocity.y > 0)
		{
			transform.eulerAngles = new Vector3 (0, 0, 30f);
		}
		else
		{
			transform.eulerAngles = new Vector3 (0, 0, -30f);
		}
	}
}
