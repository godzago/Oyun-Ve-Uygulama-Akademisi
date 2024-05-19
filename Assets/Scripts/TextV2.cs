using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Car
{
    public class TextV2 : Test
    {
        internal override void AddFual()
        {
            Debug.Log("Full");
            fuel += 5;
        }

        internal override void Move()
        {
            Debug.Log("Moved");
        }

        private void Start()
        {
            wheel = 4;
            Move();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                AddFual();
            }
        }
    }
}

