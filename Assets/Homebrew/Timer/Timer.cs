using System;
 
using UnityEngine;



namespace Homebrew
{


	public class Timer : IEvent, ITick
	{

	 
		 
		public Action callBack = delegate { };
	
		private float finishTime;
		private float timer;


		public Type GetType { get; }
		public bool IsRunning { get; set; }

		public Timer(Action callBack, float finishTime)
		{
			this.callBack = callBack;
			this.finishTime = finishTime;
			 
		}
		public void Restart(Action callBack = null,float finishTime = 0.0f)
		{

			if (finishTime > 0)
				this.finishTime = finishTime;
			
			if (callBack != null)
				this.callBack = callBack;
			
			if (timer > 0)
			{

				timer = 0.0f;
				IsRunning = true;
				return;
			}

			timer = 0.0f;
			IsRunning = true;

			ManagerUpdate.AddTo(this);
		}
		public void Dispose()
		{
	    	ManagerUpdate.RemoveFrom(this);
			callBack = delegate { };
		}
		public void Tick()
		{
			if (!IsRunning) return;
			Execute();
		}
		public void Execute()
		{
			timer = Mathf.Min(timer + Time.deltaTime, finishTime);
			if (timer < finishTime) return;
			timer = 0.0f;
			IsRunning = false;
			ManagerUpdate.RemoveFrom(this);
			callBack();
		}

	}
}
 
