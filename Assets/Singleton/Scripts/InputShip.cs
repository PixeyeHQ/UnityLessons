using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputShip : MonoBehaviour {



    void Awake()
    {
        Debug.Log(ShipController.Instance.shipName);
    }
    
	
	// Update is called once per frame
	void Update () {
		
	    if (Input.GetKeyDown(KeyCode.Space))
	        Debug.Log(ShipController.Instance.shipName);
	    
	}
}
