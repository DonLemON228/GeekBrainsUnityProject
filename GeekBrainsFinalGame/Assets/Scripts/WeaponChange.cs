using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour
{
    public GameObject Ak47;
    public GameObject Makarov;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Ak47.SetActive(true);
            Makarov.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Ak47.SetActive(false);
            Makarov.SetActive(true);
        }
    }
}
