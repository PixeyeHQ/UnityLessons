using System.Collections;
using System.Collections.Generic;
using Homebrew;
using UnityEngine;

public class ManagerPool : Singleton<ManagerPool> {

 
    private Dictionary<PoolType, Pool> pools = new Dictionary<PoolType, Pool>();


    public Pool AddPool(PoolType id, int size = 0, bool reparent = true)
    {
        
        var pool = new Pool(size);
        pools.Add(id,pool);
        if (reparent)
        {
            var poolsGO = GameObject.Find("[POOLS]") ?? new GameObject("[POOLS]");
            var poolGO = new GameObject("Pool:"+id);
            poolGO.transform.SetParent(poolsGO.transform);
            

        }

        return pool;

    }
    
    
}
