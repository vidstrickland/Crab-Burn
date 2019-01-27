using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseLogic : MonoBehaviour {

    public int health;
    public Texture[] texture;
    public int currentTexture;
    bool onFire;

    // Use this for initialization
    void Start () {
        health = 1;
        onFire = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(health <= 0)
        {
            ChangeTexture();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Crab Hand")
        {
            health--;
        }
    }

    void ChangeTexture()
    {
        if (!onFire)
        {
            currentTexture++;
            currentTexture %= texture.Length;
            GetComponent<Renderer>().material.mainTexture = texture[currentTexture];
            onFire = true;
        }
    }
}
