using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{


    public GameObject prefab;

    void Awake()
    {
        ManagerPool.Instance.AddPool(PoolType.Entities, 10);
    }
    
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
            Instantiate(prefab);

        
        

    }
    
}
