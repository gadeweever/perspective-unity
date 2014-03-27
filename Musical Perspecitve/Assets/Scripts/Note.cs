using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {

	// lives: the amount of notes needed to be dragged into this
	// before it is destroyed
	private int lives;
	// spawnNumber: the amount of other notes to be spawned. 
	private int spawnNumber;
	// trajectory: the direction a note is going in if it has one
	public enum trajectory
	{
		NONE,
		LEFT,
		UP,
		RIGHT,
		DOWN
	};
	// isHittable: determines whether the note can be destroyed simply
	// by tapping the screen. if false, we should determine it should be dragged
	public bool isHittable;
	// isDraggable: refer to the above logic. Should only be draggable 
	// when the note is in range
	public bool isDraggable;
	// noteValue: determines the points gotten from a note
	public int noteValue;
	// note type
	
		
	
	
}
