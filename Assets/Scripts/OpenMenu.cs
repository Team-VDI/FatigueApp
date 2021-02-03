using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Image;
    
    public void OpenImageMenu()
    {
        if(Image != null)
        {
            Animator animator = Image.GetComponent<Animator>();
            
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }
}