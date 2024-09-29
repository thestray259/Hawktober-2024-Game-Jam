using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] Player player;

    // TODO
    // can do specific dialogue popup
    // can do action (heal player, press button to set values, etc)

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DoAction()
    {

    }

    public void HealPlayer()
    {
        // heal to full health
        if (player != null)
        {
            player.health = 100;
        }
    }
}
