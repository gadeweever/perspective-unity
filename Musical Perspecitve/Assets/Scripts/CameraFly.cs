using UnityEngine;
using System.Collections;

public class CameraFly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
	//moves the camera forward along the Z axis
	void Move()
	{
		Vector3 positionnow = transform.position;
		transform.position = Vector3.Lerp(transform.position, new Vector3(positionnow.x,positionnow.y,positionnow.z+1), .2f);
	}
	
	void CheckHit()
	{
		
	}
	
}
