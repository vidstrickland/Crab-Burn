using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeRunner : MonoBehaviour
{
    GameObject crab;
    Vector3 dudePos;
    float speed = 30;
    public float randomizer;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        dudePos = this.transform.position;
        crab = GameObject.FindGameObjectWithTag("Player");
        randomizer = Random.Range(0f, 0.025f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PushDude();
    }

    void PushDude()
    {
        rb.AddForce(transform.forward * speed);
    }
}
