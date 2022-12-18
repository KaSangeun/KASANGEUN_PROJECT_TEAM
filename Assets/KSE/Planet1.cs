using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet1 : MonoBehaviour
{
	public float angleSpeed = 10f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.up, angleSpeed * Time.deltaTime);
	}
}
