using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {

    public bool die = false;

    public int playerhealth = 100;
    public float speed;
    public RectTransform healthTransform;
    private float cachedY;
    private float minXValue;
    private float maxXValue;
    private int currentHealth;
    public GameObject FPSController;
    private int CurrentHealth
    {
        get { return currentHealth; }
        set {
            //currentHealth = value;
            //HandleHealth();
        }
    }

    public int maxHealth;
    public Text healthText;
    public Image visualHealth;
    int damage = 10;
    public float coolDown;
    private bool onCD;


    // Use this for initialization
    void Start () {
       
        /*
        cachedY = healthTransform.position.y;
        maxXValue = healthTransform.position.x;
        minXValue = healthTransform.position.x - healthTransform.rect.width;
        currentHealth = maxHealth;
        onCD = false;
      // healthTransform.GetComponent<CanvasRenderer>().
      */
    }
	
	// Update is called once per frame
	void Update () {

        if(die==true && Input.GetKeyDown(KeyCode.R))
        {
           
            Time.timeScale = 1;
            SceneManager.LoadScene("Level1");
        }

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "KillerCube")
        {
            if (playerhealth > 0) {
                playerhealth -= damage;
                Debug.Log(playerhealth);
                die = false;
            }
            else if(playerhealth <= 0)
            {
                Debug.Log(playerhealth);
                Time.timeScale = 0;
               // FPSController.transform.GetComponent<MouseLook>().XSensitivity = 0;

                die = true;

            }
          
           

        }
    }

    /*
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag =="KillerCube")
        {
            Debug.Log("hi");
            //playerhealth = playerhealth - damage;
            if(currentHealth > 0 && !onCD)
            {
                StartCoroutine(CoolDownDmg());
                CurrentHealth -= 1;
            }
        }
        //Health
       /* if (Health)
        {
            if(!onCD && currentHealth < maxHealth)
            {
                StartCoroutine(CoolDownDmg());
                CurrentHealth += 1;
            }
        }
        */
    /*
        }
        IEnumerator CoolDownDmg()
        {
            onCD = true;
            yield return new WaitForSeconds(coolDown);
            onCD = false;

        }
        private void HandleHealth()
        {
            healthText.text = "Health - " + currentHealth + " %";
            float currentXValue = MapValues(currentHealth, 0, maxHealth, minXValue, maxHealth);
            healthTransform.position = new Vector3(currentHealth, cachedY);

            if (currentHealth>maxHealth/2)
            {
                visualHealth.color = new Color32((byte)MapValues(currentHealth,maxHealth/2,maxHealth,255,0),255,0,255);
            }
            else
            {
                visualHealth.color = new Color32(255,(byte)MapValues(currentHealth, 0,maxHealth / 2, 0,255), 0, 255);

            }
        }


        private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
        {
            return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }*/

}

