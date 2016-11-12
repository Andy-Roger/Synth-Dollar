using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript2 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note2;
	private float halfStep = 1.059463094359f; 
	private float startingPitch = 1f;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton2");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		pianoKey = GameObject.Find ("Cube (2)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("actionButton2 is pressed!!!");

		note2.pitch = startingPitch * (halfStep * halfStep * halfStep * halfStep);

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note2.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;
	
	}
}
