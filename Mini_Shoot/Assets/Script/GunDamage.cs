using UnityEngine;
using System.Collections;

public class GunDamage : MonoBehaviour {
    public int DamageAmount = 10;
    public float TargetDist;
    public float AllowedRange = 30;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit Shot = new RaycastHit();
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)){
                TargetDist = Shot.distance;
                if(TargetDist < AllowedRange && Shot.collider.tag == "Enemy")
                {
                    Shot.transform.SendMessage("DeductPoints", DamageAmount);
                }
            }
        }
	}
}
