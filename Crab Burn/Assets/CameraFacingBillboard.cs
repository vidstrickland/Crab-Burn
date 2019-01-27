using UnityEngine;
using System.Collections;


public class CameraFacingBillboard : MonoBehaviour
{

    public Transform crabFinder;
    GameObject crab;

    private void Start()
    {
        crab = GameObject.FindGameObjectWithTag("Player");
        crabFinder = crab.GetComponent<Transform>();
    }

    void Update()
    {
        if(crab != null)
        {
            transform.LookAt(crabFinder);
        }
    }
}