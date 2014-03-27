using UnityEngine;
using System.Collections;

public class Currencies : MonoBehaviour {
	
	// score : total score from hitting notes, ya?
	public int  score;
	// multiplier : current running multiplier of the game
	public int multiplier;
	// Use this for initialization
	void Start () {
		score = 0;
		multiplier = 1;
	}
	
	// Add score, takes the multiplier and multiplies the value
	// given and adds it to the total score
	public void AddValue(int myvalue)
	{
		score += myvalue * multiplier;
	}
}
