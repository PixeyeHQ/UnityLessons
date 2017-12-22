using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUpdateComponent : MonoBehaviour
{

	private ManagerUpdate mng;

	public void Setup(ManagerUpdate mng)
	{
		this.mng = mng;
	}


	private void Update()
	{
		mng.Tick();
	}

	private void FixedUpdate()
	{
		mng.TickFixed();
	}


	private void LateUpdate()
	{
		mng.TickLate();
	}
	
	
}
