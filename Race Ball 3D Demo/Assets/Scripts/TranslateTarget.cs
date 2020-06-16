using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTarget : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField, Range(1.0f, 10.0f)] private float smooth;
    private Vector3 _diff;

    void Start()
    {
        _diff = target.position - transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 nexPos = target.position - _diff;
        transform.position = Vector3.Lerp(transform.position, nexPos, smooth * Time.deltaTime);
    }
}
