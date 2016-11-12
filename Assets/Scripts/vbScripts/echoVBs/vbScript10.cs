using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript10 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject echoOnText;
	private GameObject echoOffText;
	private AudioEchoFilter echo;
	private float echoToggle;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton10");

		arCam = GameObject.Find ("ARCamera");

		echoOnText = GameObject.Find("on_echo");

		echoOffText = GameObject.Find ("off_echo");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (10)");

		echoToggle = 1f;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		if (echoToggle >= 1f) 
		
		{

			echoToggle = 0f;

			onButton.GetComponent<MeshRenderer> ().enabled = false;

			arCam.GetComponent<AudioEchoFilter> ().enabled = true;

			echoOnText.transform.localScale += new Vector3(.4f,1f,1f);

			echoOffText.transform.localScale -= new Vector3(.4f,1f,1f);
		}

		else 
		
		{

			echoToggle = 1f;

			arCam.GetComponent<AudioEchoFilter> ().enabled = false;

			echoOffText.transform.localScale += new Vector3(.4f,1f,1f);

			echoOnText.transform.localScale -= new Vector3(.4f,1f,1f);
		}

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
