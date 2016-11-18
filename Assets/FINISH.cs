using UnityEngine;
using System.Collections;


public class FINISH : MonoBehaviour {

	int i = 0;
	public Vector3 BefPos = Vector3.zero; //position before 1 phase 
	public Vector3 PrePos = Vector3.zero; //present position
	// Use this for initialization

	void Start () {
		//null
	}

	// Update is called once per frame
	void Update () {
		PrePos = transform.position;
		if (i == 50) {
			if (PrePos == BefPos) {
				Application.LoadLevel ("FINISH");
			} else {
				BefPos = transform.position;
				i = 0;
			}
		} else {
			i++;
		}
	}
}