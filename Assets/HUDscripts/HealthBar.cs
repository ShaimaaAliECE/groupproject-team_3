using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{

    public Slider healthBar;
    PlayerMovementTutorial playerHealth;
    public TextMeshProUGUI healthBarNumber;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementTutorial>();
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = playerHealth.health;
        healthBarNumber.SetText(healthBar.value.ToString());
    }
}
