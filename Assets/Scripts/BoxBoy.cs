using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoy : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AudioSource audioSource;

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
            animationType = AnimationType.East;
            animator.SetBool("isEast", true);
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animationType = AnimationType.West;
            animator.SetBool("isWest", true);
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animationType = AnimationType.North;
            animator.SetBool("isNorth", true);
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            animationType = AnimationType.South;
            animator.SetBool("isSouth", true);
            return;
        }
    }

    // アニメーション終了時に呼び出される
    IEnumerator OnEastAnimationExit()
    {
        // アニメーターの仕様上1フレーム遅らせなければいけない
        yield return null;
        animator.SetBool("isEast", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.x += 1.0f;
        transform.position = pos;
    }

    // アニメーション終了時に呼び出される
    IEnumerator OnWestAnimationExit()
    {
        // アニメーターの仕様上1フレーム遅らせなければいけない
        yield return null;
        animator.SetBool("isWest", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.x -= 1.0f;
        transform.position = pos;
    }

    // アニメーション終了時に呼び出される
    IEnumerator OnNorthAnimationExit()
    {
        // アニメーターの仕様上1フレーム遅らせなければいけない
        yield return null;
        animator.SetBool("isNorth", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.z += 1.0f;
        transform.position = pos;
    }

    // アニメーション終了時に呼び出される
    IEnumerator OnSouthAnimationExit()
    {
        // アニメーターの仕様上1フレーム遅らせなければいけない
        yield return null;
        animator.SetBool("isSouth", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.z -= 1.0f;
        transform.position = pos;
    }
}
