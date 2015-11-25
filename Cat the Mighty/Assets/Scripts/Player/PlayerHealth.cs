using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider HealthSlider;
    public AudioClip deathClip;

    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    //PlayerShooting playerShooting;
    bool isDead;
    bool damaged;

	void Start(){
		DontDestroyOnLoad (gameObject);
	}

    void Awake ()
    {
        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();
        currentHealth = startingHealth;
    }


    void Update ()
    {
        if(damaged)
        {
            
        }
        else
        {
            
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        HealthSlider.value = currentHealth;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }
    }


    void Death ()
    {
        isDead = true;

        //playerShooting.DisableEffects ();

        anim.SetTrigger ("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play ();

        playerMovement.enabled = false;
        //playerShooting.enabled = false;
    }
}
