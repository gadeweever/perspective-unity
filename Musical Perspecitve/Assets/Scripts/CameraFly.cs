using UnityEngine;
using System.Collections;

public class CameraFly : MonoBehaviour {
	
	// currentValues, type Currencies: gotten from game object in level
	// holds the current relevant information for the game at hand
	// current holder holds the game object
	public GameObject currencyHolder;
	public Currencies currentValues;
	// Use this for initialization
	void Start () {
		//hitTester.transform.parent = this.transform;
		//target.position = Vector3.forward;
		
		currentValues = currencyHolder.GetComponent<Currencies>();
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
	
	
		
	#region Triggers
	// debugging purposes
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Wow, such collision");
		if(Input.anyKeyDown)
		{
			Debug.Log("Wow, you hit a note");
			currentValues.AddValue(other.gameObject.GetComponent<Note>().noteValue);
			Debug.Log(currentValues.score);
			Destroy(other.gameObject);
		}
	}
	
	void OnTriggerStay(Collider other)
	{
		
		if(Input.anyKeyDown)
		{
			Debug.Log("Wow, you hit a note");
			currentValues.AddValue(other.gameObject.GetComponent<Note>().noteValue);
			Debug.Log(currentValues.score);
			Destroy(other.gameObject);
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		
		Destroy(other.gameObject, 2f);
	}
	#endregion
	
	
}
