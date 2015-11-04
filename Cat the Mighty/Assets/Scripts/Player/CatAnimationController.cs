using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CatAnimationController : MonoBehaviour {
	
	[SerializeField]
	GameObject Cat;
	
	public enum CatAnimation
	{
		// Normal motion
		ALERT = 1,
		IDLE = 2,
		WALK = 3,
		RUN = 4,
		LOOK = 5,
		ROLL = 6,
		
	}
	
	
	public void ChangeAnimation (CatAnimation animNumber)
	{
		
		//switch (animNumber)
		/*
		{
		case CatAnimation.FLY_STRAIGHT:
		case CatAnimation.FLY_TORIGHT:
		case CatAnimation.FLY_TOLEFT:
		case CatAnimation.FLY_UP:
			changeHandPart (QueryChanHandType.PAPER);
			this.GetComponent<QueryEmotionalController>().ChangeEmotion(QueryEmotionalController.QueryChanEmotionalType.NORMAL_EYEOPEN_MOUTHCLOSE);
			break;
			
		case CatAnimation.FLY_ITEMGET:
		case CatAnimation.FLY_ITEMGET_LOOP:
			changeHandPart (QueryChanHandType.STONE);
			this.GetComponent<QueryEmotionalController>().ChangeEmotion(QueryEmotionalController.QueryChanEmotionalType.FUN_EYECLOSE_MOUTHOPEN);
			break;
			
		case QueryChanAnimationType.FLY_DAMAGE:
			changeHandPart (QueryChanHandType.NORMAL);
			this.GetComponent<QueryEmotionalController>().ChangeEmotion(QueryEmotionalController.QueryChanEmotionalType.SURPRISED_EYEOPEN_MOUTHOPEN_MID);
			break;
			
		case QueryChanAnimationType.FLY_DISAPPOINTMENT:
		case QueryChanAnimationType.FLY_DISAPPOINTMENT_LOOP:
			changeHandPart (QueryChanHandType.STONE);
			this.GetComponent<QueryEmotionalController>().ChangeEmotion(QueryEmotionalController.QueryChanEmotionalType.SAD_EYECLOSE_MOUTHOPEN);
			break;
			
		default:
			changeHandPart (QueryChanHandType.NORMAL);
			this.GetComponent<QueryEmotionalController>().ChangeEmotion(QueryEmotionalController.QueryChanEmotionalType.NORMAL_EYEOPEN_MOUTHCLOSE);
			break;
		}
		*/
		
		List<string> targetAnimations = new List<string>();
		foreach (AnimationState targetState in Cat.GetComponent<Animation>())
		{
			targetAnimations.Add(targetState.name);
		}
		targetAnimations.Sort();
		
		Cat.GetComponent<Animation>().CrossFade(targetAnimations[(int)animNumber]);
		
	}
	
}