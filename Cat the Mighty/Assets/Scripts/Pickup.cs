using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {




	public void OnTriggerEnter(Collider other)
	{
		//m_HUDElement.count++;
		Destroy(gameObject);
	}
}
