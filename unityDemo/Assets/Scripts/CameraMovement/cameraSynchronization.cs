using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraSynchronization : MonoBehaviour
{
    public Transform refTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = refTransform.localPosition;
        transform.localRotation = refTransform.localRotation;
    }
}
