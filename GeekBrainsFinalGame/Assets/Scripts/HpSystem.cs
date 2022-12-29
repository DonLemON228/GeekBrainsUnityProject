using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSystem : MonoBehaviour
{
    [SerializeField] int maxHealth;
    [SerializeField] HealthBar healthBar;
    public float currentHealth;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetBarValue(currentHealth, maxHealth);
    }

    public void GetDamage(int _count)
    {
        animator.SetTrigger("Damage");
        currentHealth -= _count;
        healthBar.SetBarValue(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void StopDamage()
    {

    }
}
