using UnityEngine;
using System.Collections;

public class CameraFly : MonoBehaviour {
	
	public GameObject hitTester;
	
	// Use this for initialization
	void Start () {
		//hitTester.transform.parent = this.transform;
		//target.position = Vector3.forward;
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		
	}
	
	//moves the camera forward along the Z axis
	Vector3 Move()
	{
		Vector3 positionnow = transform.position;
		transform.position = Vector3.Lerp(transform.position, new Vector3(positionnow.x,positionnow.y,positionnow.z+1), .2f);
		return transform.position;
	}
	
	void CheckHit()
	{
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Wow, such collision");
	}
	
}
