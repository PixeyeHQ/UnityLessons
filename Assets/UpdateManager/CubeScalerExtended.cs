using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScalerExtended : MonoCached {
   
    
    
    
    public override void OnTick()
    {
        var val = Mathf.Sin(Time.time);
        transform.localScale = Vector3.one * val;
    }
    
    
    
}
