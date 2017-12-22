using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour {


	public List<ManagerBase> managers = new List<ManagerBase>();


	void Awake()
	{
		foreach (var managerBase in managers)
		{
			Toolbox.Add(managerBase);
		}
	}
 
}
