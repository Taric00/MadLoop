using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kod : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        StartCoroutine("WaitAnim");
    }

    IEnumerator WaitAnim(){
        yield return new WaitForSecondsRealtime(7.9f);
        animator.enabled = false;
    }
}
