using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3 (15, 35, 55) * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
	
}
