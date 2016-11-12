using UnityEngine;
using System.Collections;
using Vuforia;

public class vbReverbOn : MonoBehaviour, IVirtualButtonEventHandler  {

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

		vbButtonObject = GameObject.Find ("actionButton18");

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

		onButton = GameObject.Find ("Cube (18)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		chorus.SetActive (false);
		btn14.SetActive (false);
		btn15.SetActive (false);
		btn16.SetActive (false);

		echo.SetActive (false);
		btn8.SetActive (false);
		btn9.SetActive (false);
		btn10.SetActive (false);

		reverb.SetActive (true);
		btn11.SetActive (true);
		btn12.SetActive (true);
		btn13.SetActive (true);

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}
}

