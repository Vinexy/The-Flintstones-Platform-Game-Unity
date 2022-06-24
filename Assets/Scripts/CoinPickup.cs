using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinPickup : MonoBehaviour {


    [SerializeField] GameObject eatSound;

        private void OnTriggerEnter2D(Collider2D collision)
        {

            Instantiate(eatSound, transform.position, transform.rotation);
            Destroy(gameObject);

        }
    
    
    
}
