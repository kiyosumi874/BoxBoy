using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoy : MonoBehaviour
{
    [SerializeField] Animator animator;

    enum AnimationType
    {
        East,
        West,
        North,
        South,
        Idle
    }

    AnimationType animationType = AnimationType.Idle;

    void Update()
    {
        if (animationType != AnimationType.Idle)
        {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            StartCoroutine(StartEastAnimation());
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            StartCoroutine(StartWestAnimation());
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            StartCoroutine(StartNorthAnimation());
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine(StartSouthAnimation());
            return;
        }
    }

    IEnumerator StartEastAnimation()
    {
        animationType = AnimationType.East;
        animator.SetBool("isEast", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isEast", false);
                animationType = AnimationType.Idle;
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
        animationType = AnimationType.West;
        animator.SetBool("isWest", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isWest", false);
                animationType = AnimationType.Idle;
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
        animationType = AnimationType.North;
        animator.SetBool("isNorth", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isNorth", false);
                animationType = AnimationType.Idle;
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
        animationType = AnimationType.South;
        animator.SetBool("isSouth", true);
        while (true)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                animator.SetBool("isSouth", false);
                animationType = AnimationType.Idle;
                var pos = transform.position;
                pos.z -= 1.0f;
                transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }
}
