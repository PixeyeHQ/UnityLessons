using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{


    public GameObject prefab;

    public int amount = 10000;
    
    
	// Use this for initialization
	void Start () {

	    for (var i = 0; i < amount; i++)
	    {
	        Instantiate(prefab);
	    }
	    
	}

}
