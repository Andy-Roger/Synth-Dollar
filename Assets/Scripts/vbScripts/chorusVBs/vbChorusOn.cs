using UnityEngine;
using System.Collections;
using Vuforia;

public class vbChorusOn : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject chorus;
	private GameObject echo;
	private GameObject reverb;

	private GameObject btn8;
	private GameObject btn9;
	private GameObject btn10;

	private GameObject btn11;
	private GameObject btn12;
	private GameObject btn13;

	private GameObject btn14;
	private GameObject btn15;
	private GameObject btn16;


	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton19");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		chorus = GameObject.Find ("chorusUI");

		btn14 = GameObject.Find ("actionButton14");
		btn15 = GameObject.Find ("actionButton15");
		btn16 = GameObject.Find ("actionButton16");

		echo = GameObject.Find ("echoUI");

		btn8 = GameObject.Find ("actionButton8");
		btn9 = GameObject.Find ("actionButton9");
		btn10 = GameObject.Find ("actionButton10");

		reverb = GameObject.Find ("reverbUI");

		btn11 = GameObject.Find ("actionButton11");
		btn12 = GameObject.Find ("actionButton12");
		btn13 = GameObject.Find ("actionButton13");

		onButton = GameObject.Find ("Cube (19)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		
		onButton.GetComponent<MeshRenderer> ().enabled = false;

		chorus.SetActive (true);
		btn14.SetActive (true);
		btn15.SetActive (true);
		btn16.SetActive (true);

		echo.SetActive (false);
		btn8.SetActive (false);
		btn9.SetActive (false);
		btn10.SetActive (false);

		reverb.SetActive (false);
		btn11.SetActive (false);
		btn12.SetActive (false);
		btn13.SetActive (false);

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}
}
