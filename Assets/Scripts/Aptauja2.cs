using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aptauja2 : MonoBehaviour
{
    public GameObject Panel;

    public void NextQuestion_1()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Q1");
                animator.SetBool("Q1", !isOpen);
            }
        }
    }
    public void NextQuestion_2()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Q2");
                animator.SetBool("Q2", !isOpen);
            }
        }
    }
    public void NextQuestion_3()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Q3");
                animator.SetBool("Q3", !isOpen);
            }
        }
    }
    public void NextQuestion_4()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Q4");
                animator.SetBool("Q4", !isOpen);
            }
        }
    }
    public void NextQuestion_5()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Q5");
                animator.SetBool("Q5", !isOpen);
            }
        }
    }
}
