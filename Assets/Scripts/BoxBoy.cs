using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoy : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(StartEastAnimation());
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(StartWestAnimation());
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(StartNorthAnimation());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(StartSouthAnimation());
        }
    }

    // ↓ボタンを連打するとアニメーターが死ぬバグが存在

    IEnumerator StartEastAnimation()
    {
        if (animator.GetBool("isEast"))
        {
            yield break;
        }
        animator.SetBool("isEast", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isEast", false);
                var pos = transform.position;
                pos.x += 1.0f;
                transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }

    IEnumerator StartWestAnimation()
    {
        if (animator.GetBool("isWest"))
        {
            yield break;
        }
        animator.SetBool("isWest", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isWest", false);
                var pos = transform.position;
                pos.x -= 1.0f;
                transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }

    IEnumerator StartNorthAnimation()
    {
        if (animator.GetBool("isNorth"))
        {
            yield break;
        }
        animator.SetBool("isNorth", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isNorth", false);
                var pos = transform.position;
                pos.z += 1.0f;
                transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }

    IEnumerator StartSouthAnimation()
    {
        if (animator.GetBool("isSouth"))
        {
            yield break;
        }
        animator.SetBool("isSouth", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isSouth", false);
                var pos = transform.position;
                pos.z -= 1.0f;
                transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }
}
