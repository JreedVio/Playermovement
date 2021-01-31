using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimController : MonoBehaviour
{
	private Animator anim;
	private void Awake()
	{
		anim = GetComponent<Animator>();
	}
	public void AnimMove(float move)
	{
		if (move >= 0.2f || move <= -0.2f) // motion animation trigger
		{
			anim.SetBool("IsMoving", true);
		}
		else
		{
			anim.SetBool("IsMoving", false);
		}
	}
	public void AnimJump()
	{
		anim.SetBool("IsJumping", true);
	}
	public void AnimGrounded()
	{
		//if(this.anim.GetCurrentAnimatorStateInfo(0).IsTag("Jump"))
			anim.SetBool("IsJumping", false);
	}
}
