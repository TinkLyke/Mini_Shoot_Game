using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Player_Health : MonoBehaviour {

    public int playerhealth = 100;
    int damage = 10;
	// Use this for initialization
	void Start () {
        print(playerhealth);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void onCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag =="Player")
        {
            print("enemy touched");
            playerhealth = playerhealth - damage;
        }
        {

        }

    }

}

