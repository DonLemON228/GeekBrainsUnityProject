using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheRadioactiveZone : MonoBehaviour
{
    public HpSystem hpSysteam;
    public AudioSource damageSource;
    public AudioClip deathSound;
    public AudioSource GeigerSource;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(ToDamage());
            GeigerSource.Play();
        }
    }

    private IEnumerator ToDamage()
    {
        //Отнимаем 1ед здоровья пока здоровье есть или пока корутина не будет остановлена
        while (hpSysteam.currentHealth > 0)
        {
            hpSysteam.GetDamage(1);
            damageSource.PlayOneShot(deathSound);
            yield return new WaitForSeconds(3.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StopAllCoroutines();
            GeigerSource.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
