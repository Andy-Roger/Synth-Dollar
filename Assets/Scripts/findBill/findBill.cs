using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class findBill : MonoBehaviour {

	private GameObject dollar;

	// Use this for initialization
	void Start () {
		dollar = GameObject.Find ("centerText");

	}

	void Update () {

		if (dollar.GetComponent<MeshCollider> ().enabled == true) {
			gameObject.GetComponent <Text> ().enabled = false;
		
		} 

		if (dollar.GetComponent<MeshCollider> ().enabled == false)
		{
			gameObject.GetComponent <Text> ().enabled = true;
		}
			
	}
}
