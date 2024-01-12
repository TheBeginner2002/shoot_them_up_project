using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shmup
{
    public class minion : WeaponPower
    {
        // Start is called before the first frame update
        void Start()
        {
            // Kiểm tra xem thuộc tính isHelperActive có phải là true hay không
            if (isHelperActive)
            {
                // Đặt thuộc tính enabled của trợ thủ thành true
                enabled = true;
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
