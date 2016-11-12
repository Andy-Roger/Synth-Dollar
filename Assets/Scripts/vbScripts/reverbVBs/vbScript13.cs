using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript13 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject reverbOnText;
	private GameObject reverbOffText;
	private AudioReverbFilter reverb;
	private float reverbToggle;



	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton13");

		arCam = GameObject.Find ("ARCamera");

		reverbOnText = GameObject.Find("on_reverb");

		reverbOffText = GameObject.Find("off_reverb");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (13)");

		reverbToggle = 1f;
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (reverbToggle >= 1f) 
		
		{
			reverbToggle = 0f;

			arCam.GetComponent<AudioReverbFilter> ().enabled = true;

			reverbOnText.transform.localScale += new Vector3(.4f,1f,1f);

			reverbOffText.transform.localScale -= new Vector3(.4f,1f,1f);

		} 

		else
		
		{
			reverbToggle = 1f;

			arCam.GetComponent<AudioReverbFilter> ().enabled = false;

			reverbOnText.transform.localScale -= new Vector3(.4f,1f,1f);

			reverbOffText.transform.localScale += new Vector3(.4f,1f,1f);
				
		}

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
