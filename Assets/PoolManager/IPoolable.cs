using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Homebrew{
public interface IPoolable
{
    void OnSpawn();
    void OnDespawn();
    
}
}
