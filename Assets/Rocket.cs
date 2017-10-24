using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

	public Rigidbody rBody;

	// Use this for initialization
	void Start ()
	{
		rBody.AddForce (Vector3.up * 10f, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
