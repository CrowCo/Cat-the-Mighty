using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GUIController : MonoBehaviour {
	
	Vector3 PosDefault;
	[SerializeField]
	GameObject CameraObj;
	private bool cameraUp;
	[SerializeField]
	GameObject Cat;
	//private int querySoundNumber;
	private int targetNum;
	//List<string> targetSounds = new List<string>();


	void Start() {
		
		PosDefault = CameraObj.transform.localPosition;
		cameraUp = false;
		//querySoundNumber = 0;
		/*
		foreach (AudioClip targetAudio in queryChan.GetComponent<QuerySoundController>().soundData)
		{
			targetSounds.Add(targetAudio.name);
		}
		targetNum = targetSounds.Count - 1;
		/
		*/

		ChangeAnimation(CatAnimationController.CatAnimation.IDLE);
		
	}
	
	void OnGUI(){
		
		//AnimationChange ------------------------------------------------
		
		if(GUI.Button(new Rect(0,0,100,100),"Alert"))
		{
			ChangeAnimation(CatAnimationController.CatAnimation.ALERT);
		}
		if(GUI.Button(new Rect(0,100,100,100),"Idle"))
		{
			ChangeAnimation(CatAnimationController.CatAnimation.IDLE);
		}
		if(GUI.Button(new Rect(0,200,100,100),"Walk"))
		{
			ChangeAnimation(CatAnimationController.CatAnimation.WALK);
		}
		if(GUI.Button(new Rect(0,300,100,100),"Run"))
		{
			ChangeAnimation(CatAnimationController.CatAnimation.RUN);
		}
		if(GUI.Button(new Rect(0,400,100,100),"Roll"))
		{
			ChangeAnimation(CatAnimationController.CatAnimation.ROLL);
		}


		//FaceChange ------------------------------------------------
		
		if(GUI.Button(new Rect(Screen.width -100 ,0,100,100),"Normal"))
		{
			ChangeFace(CatEmotion.CatEmotionType.NORMAL);
		}
		if(GUI.Button(new Rect(Screen.width -100,100,100,100),"Sad"))
		{
			ChangeFace(CatEmotion.CatEmotionType.SAD);
		}
		if(GUI.Button(new Rect(Screen.width -100,200,100,100),"Anger"))
		{
			ChangeFace(CatEmotion.CatEmotionType.ANGER);
		}
		/*if(GUI.Button(new Rect(Screen.width -100,300,100,100),"Sad"))
		{
			ChangeFace(QueryEmotionalController.QueryChanEmotionalType.SAD_EYEOPEN_MOUTHCLOSE);
		}
		if(GUI.Button(new Rect(Screen.width -100,400,100,100),"Fun"))
		{
			ChangeFace(QueryEmotionalController.QueryChanEmotionalType.FUN_EYEOPEN_MOUTHCLOSE);
		}
		if(GUI.Button(new Rect(Screen.width -100,500,100,100),"Surprised"))
		{
			ChangeFace(QueryEmotionalController.QueryChanEmotionalType.SURPRISED_EYEOPEN_MOUTHOPEN);
		}
		*/


		//CameraChange --------------------------------------------

		if (GUI.Button (new Rect (Screen.width / 2 -75, 0, 150, 80), "Camera"))
		{
			if (cameraUp == true)
			{
				CameraObj.GetComponent<Camera>().fieldOfView = 60;
				CameraObj.transform.localPosition = new Vector3(PosDefault.x, PosDefault.y, PosDefault.z);
				cameraUp = false;
			}
			else
			{
				CameraObj.GetComponent<Camera>().fieldOfView = 25;
				CameraObj.transform.localPosition = new Vector3(PosDefault.x, PosDefault.y + 0.5f, PosDefault.z);
				cameraUp = true;
			}
		}


		//Sound ---------------------------------------------------------
		
		/*if(GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height - 100, 50 ,100), "<---"))
		{
			querySoundNumber--;
			if (querySoundNumber < 0)
			{
				querySoundNumber = targetNum;
			}
		}
		if(GUI.Button(new Rect(Screen.width / 2 + 100, Screen.height - 100, 50 ,100), "--->"))
		{
			querySoundNumber++;
			if (querySoundNumber > targetNum)
			{
				querySoundNumber = 0;
			}
			
		}
		if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height - 70, 200 ,70), "Play"))
		{
			queryChan.GetComponent<QuerySoundController>().PlaySoundByNumber(querySoundNumber);
		}
		
		GUI.Label (new Rect(Screen.width / 2 - 100, Screen.height - 100, 200, 30), (querySoundNumber+1) + " / " + (targetNum+1) + "  :  " + targetSounds[querySoundNumber]);


		//SceneChange --------------------------------------------
		
		if (GUI.Button (new Rect (Screen.width -100,700,100,100), "to Fly Mode"))
		{
			Application.LoadLevel("02_OperateQuery_Flying");
		}*/

	}


	void ChangeFace (CatEmotion.CatEmotionType faceNumber) {

		Cat.GetComponent<CatEmotion>().ChangeEmotion(faceNumber);

	}


	void ChangeAnimation (CatAnimationController.CatAnimation animNumber) {

		Cat.GetComponent<CatAnimationController>().ChangeAnimation(animNumber);

	}

}
