using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool  {


    private List<IPoolable> pooledObjects = new List<IPoolable>();
    
    public Pool(int size = 0)
    {
        pooledObjects = new List<IPoolable>(size);
    }
    
}
