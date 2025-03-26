using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTest : MonoBehaviour
{
    [SerializeField, Range(0, 1)] float test;
    [SerializeField] Material mat;
    
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }


    void Update()
    {
        mat.SetFloat("_Smooth", test);
    }
}
