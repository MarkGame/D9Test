using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemstone : MonoBehaviour {
	public float xOffset = 0f;
	public float yOffset = 0f;
	public float interval = 1f;

	public GameObject[] GemstoneBgs;
	public int GemstoneType;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdatePosition(int y, int x){
		this.transform.position = new Vector3 (x*interval + xOffset, y*interval + yOffset, 0);
	
	
	}
}
