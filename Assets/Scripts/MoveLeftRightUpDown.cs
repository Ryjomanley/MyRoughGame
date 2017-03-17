using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRightUpDown : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//This moves left and right
		transform.position += Vector3.right * Input.GetAxis ("Horizontal") * Time.deltaTime;
		//This moves up and down
		transform.position += Vector3.up * Input.GetAxis ("Vertical") * Time.deltaTime;

	}
}
