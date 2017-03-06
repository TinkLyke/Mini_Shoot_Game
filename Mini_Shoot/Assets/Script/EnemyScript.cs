using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    public int EnemyHealth = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
	}

    void DeductPoints (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    
}
