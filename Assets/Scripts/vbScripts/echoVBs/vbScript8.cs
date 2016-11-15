using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript8 : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private GameObject arCam;
	private GameObject slider;
	private AudioEchoFilter echo;

	void Start () 
	{

		vbButtonObject = GameObject.Find ("actionButton8");

		arCam = GameObject.Find ("ARCamera");

		slider = GameObject.Find ("echoSlider");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		transform.position = new Vector3 (0, 0,0);

		onButton = GameObject.Find ("Cube (8)");
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		if (slider.transform.position.z >= -.6f) 

		{
			slider.transform.Translate (0f, 0f, -.1f);

			arCam.GetComponent<AudioEchoFilter>  ().delay -= 300f;
		
		}
			
	}

	void Update ()
	{
		if (slider.transform.position.z >=  -.6f) 

		{
			arCam.GetComponent<AudioEchoFilter>  ().enabled = true;
		}

		if (slider.transform.position.z <= -.6f) 

		{
			arCam.GetComponent<AudioEchoFilter>  ().enabled = false;
		}
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Button is not pressed!!!");

		onButton.GetComponent<MeshRenderer> ().enabled = true;


	}

}
