using UnityEngine;
using System.Collections;

public class GUIRenderer : MonoBehaviour {
	
	private Currencies currentValues;
	// Use this for initialization
	void Start () {
		currentValues = GetComponent<Currencies>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		GUI.Box(new Rect (0,0,100,50), currentValues.score.ToString());
		GUI.Box(new Rect (50,0,100,50), currentValues.streak.ToString());
		GUI.Box(new Rect (50,0,100,50), currentValues.multiplier.ToString());

	}
}
