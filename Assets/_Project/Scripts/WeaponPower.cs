using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shmup
{
    public class WeaponPower : Item
    {
        public bool isCollected = false;
 //       public GameObject helperPrefab;
        public bool isHelperActive = false;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                isCollected = true;
                isHelperActive = true;
                Destroy(gameObject);
            }
        }
    }
}
