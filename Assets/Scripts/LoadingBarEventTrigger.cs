using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAnimation : MonoBehaviour
{
   private Animator mAnimator;

   //Start is called before the first frame update
   void Start()
   {
	   mAnimator = GetComponent<Animator>();
   }

   //Update is called once per frame
   void update()
   {
	   if(mAnimator != null)
	   {
		   if(Input.GetKeyDown(KeyCode.K))
		   {
			   mAnimator.SetTrigger("TriggerTest");
		   }
	   }
   }
}

