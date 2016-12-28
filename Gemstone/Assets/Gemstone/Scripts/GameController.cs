using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public Gemstone gemstone;
	public int rownum = 7;
	public int colnum = 10;
	public ArrayList gemstoneList;
	// Use this for initialization
	void Start () {
		gemstoneList = new ArrayList ();
		for(int rowIndex = 0; rowIndex < rownum; rowIndex++){
			ArrayList temp = new ArrayList ();
			for (int colIndex = 0; colIndex < colnum; colIndex++) {
				Gemstone c = Instantiate (gemstone) as Gemstone;
				c.transform.parent = this.transform;
				temp.Add (c);
				c.GetComponent<Gemstone> ().UpdatePosition (rowIndex, colIndex);
			}
			gemstoneList.Add (temp);
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
