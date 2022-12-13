using HyperCasual.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[ExecuteInEditMode]
[RequireComponent(typeof(Collider))]
public class FinishLine : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        const string k_PlayerTag = "Player";


        void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag(k_PlayerTag))
            {
                Debug.Log("Bitti");
            }
        }
    }
}
