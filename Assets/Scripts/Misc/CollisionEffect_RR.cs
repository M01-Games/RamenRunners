using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect_RR : MonoBehaviour
{
    public GameObject hitEffectPrefab;
    void OnCollisionEnter(Collision other)
    {
        Instantiate(hitEffectPrefab, other.GetContact(0).point, Quaternion.identity);
    }
}
