using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NPCEmotionController : MonoBehaviour {

	public Sprite[] Emotion;
	public GameObject NPC;

	public enum EmotionType
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
	
	
	public void ChangeEmotion (EmotionType faceNumber)
	{
		NPC.GetComponent<Image>().sprite = Emotion[(int)faceNumber];
	}
}
