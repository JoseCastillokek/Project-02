using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnonKey : MonoBehaviour {

    public GameObject myPrefab = null;
    


    private float InstantiationTimer = 4f;

    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
            if (Input.GetKey(KeyCode.S))
            if (InstantiationTimer <= 0)
        {
            Instantiate(myPrefab, transform.position, Quaternion.identity);
            InstantiationTimer = 2f;
        }
       








    }

    }
