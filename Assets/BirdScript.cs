using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D BirdCollider;
    public float FlappyStrengh;
    public LogicScript logic;
    public bool BirdIsAlive = true;
    public AudioSource AudioFlap;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BirdIsAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                BirdCollider.velocity = Vector2.up * FlappyStrengh;
                AudioFlap.Play();

            }
        }
        if(transform.position.y < -6 || transform.position.y > 6)
        {
            birdDeath();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdDeath();
    }

    public void birdDeath()
    {
        logic.GameOver();
        BirdIsAlive = false;
    }


}
