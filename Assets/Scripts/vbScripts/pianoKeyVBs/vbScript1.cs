using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript1 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject pianoKey;
	public AudioSource note1;
    private float halfStep = 1.059463094359f; 
	private float startingPitch = 1f;

	void Start () 
	{
		vbButtonObject = GameObject.Find ("actionButton1");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		pianoKey = GameObject.Find ("Cube (1)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("actionButton1 is pressed!!!");

		note1.pitch = startingPitch * (halfStep * halfStep);

		pianoKey.GetComponent<MeshRenderer> ().enabled = false;

		note1.Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		pianoKey.GetComponent<MeshRenderer> ().enabled = true;
	
	}
}
