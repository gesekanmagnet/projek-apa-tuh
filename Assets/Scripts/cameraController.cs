using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private GameObject sphere;
	private Vector3 offset;
	void Start () 
	{
		offset = transform.position - sphere.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void LateUpdate()
	{
		transform.position = sphere.transform.position + offset;
	}
}
