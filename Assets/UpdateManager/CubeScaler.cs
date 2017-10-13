using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CubeScaler : MonoBehaviour {

	
	// Update is called once per frame
    void Update ()
	{
	    var val = Mathf.Sin(Time.time);
	    transform.localScale = Vector3.one * val;
	}
}
