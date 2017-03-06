using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
            AudioSource gunsound = gameObject.GetComponent<AudioSource>();
            gunsound.Play();
            gameObject.GetComponent<Animation>().Play("GunShot");
        }
    }

   
}
