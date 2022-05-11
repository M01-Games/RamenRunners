using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter_RR : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
