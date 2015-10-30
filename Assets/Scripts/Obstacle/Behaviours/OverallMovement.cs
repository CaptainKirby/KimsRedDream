using UnityEngine;
using System.Collections;

public class OverallMovement : MonoBehaviour {

	public float speed = 1;
	void Start () 
	{
	
	}
	

	void Update () 
	{
		this.transform.position -= new Vector3(0,0, speed);
	}
}
