using UnityEngine;
using System.Collections;

public class Currencies : MonoBehaviour {
	
	// score : total score from hitting notes, ya?
	public int  score;
	// multiplier : current running multiplier of the game
	public int multiplier;
	// streak : consecutive notes hit to date
	public int streak;
	// multiplierConstant : the amount of new notes needed to break a new multiplier
	public int multiplierConstant;
	// maxNatural : maximum natural multiplier gained from just hitting notes
	public int maxNatural;
	// Use this for initialization
	void Start () {
		score = 0;
		multiplier = 1;
		streak = 0;
		multiplierConstant = 10;
	}
	
	// Add score, takes the multiplier and multiplies the value
	// given and adds it to the total score
	public void AddValue(int myvalue)
	{
		score += myvalue * multiplier;
		this.streak++;
		SetMultiplier();
	}
	
	// sets the multiplier based on the current streak
	// should never be called outside of AddValue
	// except in cases of extra vision
	private void SetMultiplier()
	{
		// if we have reacher our maximum
		if(this.multiplier > this.maxNatural)
			return;
		
		// if the multiplier is one, don't set it to zero with integer arithmetic
		this.multiplier = Math.Max(this.streak / 10, 1);		
	}
}
