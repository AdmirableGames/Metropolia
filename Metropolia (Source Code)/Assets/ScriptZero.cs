using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptZero : MonoBehaviour {
	public float Timer1;
	private float Timer2;
	// Use this for initialization
	void Start () {
		Timer2 = Timer1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, -Time.deltaTime*50);

		if (Timer2 > 0) {Timer2 -= Time.deltaTime;}
		if (Timer2 <= 0) {SceneManager.LoadScene ("Scene");}
		
	}
}
