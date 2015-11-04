using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BitManager : MonoBehaviour {

	public int BitCount;
	Text BitPrint;
	// Use this for initialization
	void Start () {
		BitCount = 500000;
		BitPrint = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		BitPrint.text = "" + BitCount;
	}
	public void ChangeAmount (int money)
	{
		BitCount += money;
	}
}
