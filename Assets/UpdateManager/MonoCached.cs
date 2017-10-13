using UnityEngine;
using System.Collections.Generic;

public  class MonoCached : MonoBehaviour {


    public static List<MonoCached> allTicks  = new List<MonoCached>(10000);
    public static List<MonoCached> allFixedTicks = new List<MonoCached>();
    public static List<MonoCached> allLateTicks = new List<MonoCached>();


    private void OnEnable()
    {
        allTicks.Add(this);
    }


    private void OnDisable()
    {
        allTicks.Remove(this);
    }

    public void Tick()
    {
        OnTick();
    }
    public void FixedTick()
    {
        
    }
    public void LateTick()
    {
        
    }


    public virtual void OnTick()
    {
        
    }



}
