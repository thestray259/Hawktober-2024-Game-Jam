using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;

    public int health = 100;
    public int maxHealth = 100;
    public bool isDead = false;

    // TODO
    // player needs to be able to see in direction it's facing so it can see if it can interact with anything (raycasting)
    // be able to press a button to interact

    private void Start()
    {
        
    }

    private void Update()
    {
        if (CheckIfDead(health) == true || isDead)
        {
            // dead
            isDead = true;

            // stop movement
            playerMovement.enabled = false;
        }
    }

    private void FixedUpdate()
    {
        
    }


    // check whenever taking damage
    public bool CheckIfDead(int health)
    {
        if (health <= 0) { return true; }
        else return false;
    }
}
