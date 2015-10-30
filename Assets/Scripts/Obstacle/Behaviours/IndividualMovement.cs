using UnityEngine;
using System.Collections;

public class IndividualMovement : MonoBehaviour {

	public Vector2 moveOneWay;
	// Use this for initialization
	void Start () {
	
	}

	void Update () {
	
		if(moveOneWay != Vector2.zero)
		{
			transform.position += new Vector3(moveOneWay.x, 0 , moveOneWay.y) /100;
		}
	}
}
