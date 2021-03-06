﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterable : MonoBehaviour
{
    [SerializeField]
    protected Animator animator;

    protected bool watered = false;


    public virtual void Watered()
    {
        if (!watered)
        {
            animator.SetTrigger("Water");
            watered = true;
        }
    }
}
