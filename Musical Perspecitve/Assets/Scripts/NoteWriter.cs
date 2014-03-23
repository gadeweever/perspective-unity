using UnityEngine;
using System.Collections;

public class NoteWriter : MonoBehaviour {
	
	public Vector3 startposition;
	public Transform prefab;
	private DistanceGenerator noteGenerator;
	private int currentNoteDraw;
	// Use this for initialization
	void Start () {
		noteGenerator = GetComponent<DistanceGenerator>();
		currentNoteDraw = 0;
		noteGenerator.SetOrigin(transform.position + new Vector3(0,0,8));
		Seed();
		
	}
	
	
	void Seed()
	{
		noteGenerator.noteNumber = 50;
		noteGenerator.noteDifferences = new Vector2[50];
		noteGenerator.phasePositions = new int[50];
		noteGenerator.phasePositions[0] = 50;
		noteGenerator.notePositions = new Vector3[noteGenerator.noteNumber];
		float[] xs = new float[50],ys = new float[50]; 
		
		Debug.Log(ys.Length);
		for(int i = 0; i < ys.Length ; i++)
		{
			ys[i] = 10f;
			xs[i] = 0;
		}
		
		noteGenerator.CreateNoteDifferences(xs,ys);
		noteGenerator.CreateNotePositions();
		Draw();
	}
	
	void Draw()
	{

		for(int i = 0 ; i < noteGenerator.phasePositions[noteGenerator.nextPhaseCalc -1] ; i++)
		{
			Instantiate(prefab,noteGenerator.notePositions[currentNoteDraw], Quaternion.Euler(0,-90,0));
			currentNoteDraw++;
		}
	}
}
