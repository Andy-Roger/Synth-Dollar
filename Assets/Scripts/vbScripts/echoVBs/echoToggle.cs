using UnityEngine;
using System.Collections;
using Vuforia;

public class echoToggle : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton; 
	private GameObject arCam; 
	private float loopTog;
	private GameObject loopOn; 
	private GameObject loopOff; 

	void Start () 
	{

		vbButtonObject = GameObject.Find ("echoLooper");

		arCam = GameObject.Find ("ARCamera");

		loopOn = GameObject.Find ("on_loop");

		loopOff = GameObject.Find ("off_loop");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		loopTog = 1f;

		onButton = GameObject.Find ("echoButton");

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("sdfkjhsdfkjh");

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (loopTog >= 1f) 
		
		{
			loopTog = 0f;

			arCam.GetComponent<AudioEchoFilter> ().decayRatio = 1f;

			loopOn.transform.localScale += new Vector3(0f,0.7681009f,0f);

			loopOff.transform.localScale -= new Vector3(0f,0.7681009f,0f);
		}

		else
		{
			loopTog = 1f;

			arCam.GetComponent<AudioEchoFilter> ().decayRatio = .2f;

			loopOn.transform.localScale -= new Vector3(0f,0.7681009f,0f);

			loopOff.transform.localScale += new Vector3(0f,0.7681009f,0f);
		}

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = true;


	}

}

