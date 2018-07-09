using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightt : MonoBehaviour {

    public Light luz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        luz.GetComponent<Light>().intensity = 100.0f;
        StartCoroutine(_Return());        
    }

    public IEnumerator _Return() {
        yield return new WaitForSeconds(5F);
        Application.LoadLevel("Menu");
    }
}
