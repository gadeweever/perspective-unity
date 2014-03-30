using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {
	
	
	// noteType : specifies the kind of note class is currently on the note
	public enum noteType
	{
		Standard,
		Draggable
	}

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
	// noteValue: determines the points gotten from a note
	public int noteValue;
	
	void Start()
	{
		NoteSetup();
	}
	
	
	public int GetNoteValue()
	{
		return this.noteValue;
	}
	
	// noteSetup: sets any new spanwed notes with default valeus
	// if a note is spawnd as a draggable note, its parent should be that which spawned it
	private void NoteSetup()
	{
		
	}
	
	
	
	
}
