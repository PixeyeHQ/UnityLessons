 
using UnityEngine;

public class ShipMover : MonoBehaviour {

 
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(ShipController.Instance.gameObject);
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(GameController.Instance.gameObject);
        }
        
    }
 
}
