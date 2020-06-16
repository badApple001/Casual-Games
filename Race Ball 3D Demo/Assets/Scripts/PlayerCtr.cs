using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{
    [SerializeField,Range(10000.0f,20000.0f)] private float LaunchForce = 15000;
    [SerializeField] private Rigidbody rig = null;
    private Vector3 forward;
    // Start is called before the first frame update
    void Start()
    {
        if (!rig) { rig = GetComponent<Rigidbody>(); }
        this.forward = this.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //弹射
        if( Input.GetMouseButtonDown(0) || Input.touchCount > 0 )
        {
            Launch();
        }
    }

    void Launch()
    {
        rig.AddForce(forward * Time.deltaTime * LaunchForce );
    }

    private void OnCollisionEnter(Collision collision)
    {
      //  Debug.Log(collision.transform.tag);
    }

}
