using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dada : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public class Tree : MonoBehaviour
    {
        void Update()
        {
            if (Vector3.Distance(transform.position, Camera.main.transform.position) > 500)
                Destroy(gameObject);

        }
    }
}
