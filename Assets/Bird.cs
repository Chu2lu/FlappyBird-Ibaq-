using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public bool dead;
    public float veclocity = 2f;
    public Rigidbody2D rb2;
    public AudioSource ses;
    public AudioSource SoundDeath;
    public GameManager GM;
    public GameObject DeathScreen;
    public GameObject PauseScreen;

    private void Start()
    { 
      Time.timeScale= 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2.velocity = Vector2.up * veclocity;
            ses.Play();
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           PauseScreen.SetActive(true);
           Time.timeScale= 0;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score")
        {
            GM.UpdateScore(); 

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundDeath.Play();
        if (collision.gameObject.tag=="Deathzone")
        {
            dead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    } 
}
