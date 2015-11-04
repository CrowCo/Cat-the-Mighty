using UnityEngine;
using System.Collections;

public class CatEmotion : MonoBehaviour {
	
	[SerializeField]
	Material[] Emotion;
	
	[SerializeField]
	GameObject Cat;
	
	public enum CatEmotionType
	{
		// Normal emotion
		NORMAL = 0,
		
		// Anger emotion
		ANGER = 1,
		
		// Sad emotion
		SAD = 2,
		
		// Fun emotion
		HAPPY = 4,
		HAPPY_01 = 5,
		
		// Surprised emotion
		
	}
	
	
	public void ChangeEmotion (CatEmotionType faceNumber)
	{
		Cat.GetComponent<Renderer>().material = Emotion[(int)faceNumber];
	}
	
}

