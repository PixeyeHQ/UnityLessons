using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

	    for (var i = 0; i < MonoCached.allTicks.Count; i++)
	    {
	        MonoCached.allTicks[i].Tick();
	    }
	    
	}

    void FixedUpdate()
    {
        for (var i = 0; i < MonoCached.allFixedTicks.Count; i++)
        {
            MonoCached.allTicks[i].FixedTick();
        }
    }

    void LateUpdate()
    {
        for (var i = 0; i < MonoCached.allLateTicks.Count; i++)
        {
            MonoCached.allTicks[i].LateTick();
        }
    }
    
    
    
}
