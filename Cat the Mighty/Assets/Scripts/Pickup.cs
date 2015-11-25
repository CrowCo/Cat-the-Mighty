using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {


	//note the activity of the pickup from an assigned number


	public void OnTriggerEnter(Collider other)
	{
		//m_HUDElement.count++;
		//Add health to the player
		Destroy(gameObject);

	}
}
