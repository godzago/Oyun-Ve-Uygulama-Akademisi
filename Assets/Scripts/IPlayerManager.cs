using Charakter;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Charakter
{
    public abstract class IPlayerManager : MonoBehaviour
    {
        [SerializeField] protected float movementSpeed;
        [SerializeField] protected bool ÝsGround;
        [SerializeField] protected bool ÝsEarea;
        [SerializeField] protected bool uýActicite = false;
    }
}

