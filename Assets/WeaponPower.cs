using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shmup
{
    public class WeaponPower : Item
    {
        public GameObject newBulletPrefab;
        void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    // Gọi phương thức ChangeBulletType trong lớp Player
/*                    player.ChangeBulletType(newBulletPrefab);*/

                    // Hủy đối tượng power-up
                    Destroy(gameObject);
                }
            }
            else
            {
                Debug.LogError("Collider 'other' is null!");
            }

        }
    }
}
