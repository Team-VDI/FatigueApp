using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnim : MonoBehaviour
{
    public GameObject Panel;

   public void OpenPanel()
    {
        if(Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }

    public void OpenPanel2()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open2");
                animator.SetBool("open2", !isOpen);
            }
        }
    }
}
