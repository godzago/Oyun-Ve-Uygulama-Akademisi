using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Car
{
    public abstract class Test : MonoBehaviour
    {
        #region SerializeField
        [SerializeField] protected float speed;
        protected ushort wheel;
        [SerializeField] protected ushort fuel;
        #endregion

        internal abstract void Move();
        internal abstract void AddFual();
    }
}

