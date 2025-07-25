﻿using UnityEngine;

namespace GADVDataTypes
{
    public class SpriteMover : MonoBehaviour
    {
        private int moveSpeed = 3;
        private float timeElapsed = 2.5f;

        void Update()
        {
            // Implicit conversion of moveSpeed (int → float)
            float totalMovement = moveSpeed + timeElapsed;
            transform.position = new Vector3(totalMovement, 0, 0);

            // int roundedSpeed = totalMovement;

            // Explicit conversion of totalMovement (truncates decimal)
            int roundedSpeed = (int)totalMovement;
        }
    }
}
