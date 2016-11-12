using UnityEngine;
using System.Collections;
using Vuforia;

public class soundOne : MonoBehaviour, IVirtualButtonEventHandler  {

	private GameObject vbButtonObject;
	private GameObject onButton;
	private float octaveToggle;
	public AudioClip sound1;
	AudioSource zero;
	AudioSource one;
	AudioSource two;
	AudioSource three;
	AudioSource four;
	AudioSource five;
	AudioSource six;
	AudioSource seven;
	GameObject bCube1;
	GameObject bCube2;
	GameObject bCube3;
	GameObject bCube4;


	void Start () 
	{
		bCube1 = GameObject.Find ("babyCube1");
		bCube2 = GameObject.Find ("babyCube2");
		bCube3 = GameObject.Find ("babyCube3");
		bCube4 = GameObject.Find ("babyCube4");

		onButton = GameObject.Find ("Cube soundOne");

		vbButtonObject = GameObject.Find ("soundOne");
		 
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();

		zero = allMyAudioSources [0];
		one = allMyAudioSources [1];
		two = allMyAudioSources [2];
		three = allMyAudioSources [3];
		four = allMyAudioSources [4];
		five = allMyAudioSources [5];
		six = allMyAudioSources [6];
		seven = allMyAudioSources [7];

		zero.clip = sound1;
	}
		

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) 

	{
		Debug.Log ("Bxxxokxokxokxokxoskxosxksokxsokx");

		onButton.GetComponent<MeshRenderer> ().enabled = false;

		zero.clip = sound1;

		one.clip = sound1;

		two.clip = sound1;

		three.clip = sound1;

		four.clip = sound1;

		five.clip = sound1;

		six.clip = sound1;

		seven.clip = sound1;

	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) 

	{
 
		onButton.GetComponent<MeshRenderer> ().enabled = true;

	}

}
