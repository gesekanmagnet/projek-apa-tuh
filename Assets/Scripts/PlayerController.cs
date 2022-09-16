using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	// Use this for initialization
	public Rigidbody rb;
	public float kecepatan;
	public int jumlahPick;
	public Text skor;
	public Text menang;
	float moveX;
	float moveY;
	void Start () 
	{
		jumlahPick = 0;
		rb = GetComponent<Rigidbody>();
		kecepatan = 8f;
		JumlahSkor();
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveX * kecepatan, 0.0f, moveY * kecepatan);
		rb.AddForce(movement);
		if(jumlahPick == 2)
		{
			TextWin();
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Cube")
		{
			jumlahPick += 1;
			JumlahSkor();
		}
	}
	
	void JumlahSkor()
	{
		skor.text = "Skor: " + jumlahPick.ToString();
	}
	
	void TextWin()
	{
		menang.text = "MENANG!";
	}
}
