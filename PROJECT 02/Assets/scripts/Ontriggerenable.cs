using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggerenable : MonoBehaviour {


    public GameObject hide;
    public GameObject hide2;
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Collide")

            hide.SetActive(false);
            hide2.SetActive(true);
            
    }




}
