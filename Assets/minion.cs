using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shmup
{
    public class minion : WeaponPower
    {
         public GameObject helperPrefab;
        void Start()
        {
            if (isHelperActive)
            {

                helperPrefab.SetActive(true);
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
