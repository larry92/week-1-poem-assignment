using UnityEngine;
using System.Collections;

public class ThePoet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log( "Hello World" );
		GetComponent<TextMesh>().text="Today a world was born\nA world of wind and sea\nA world devoid of people\nWandering endlessly";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
