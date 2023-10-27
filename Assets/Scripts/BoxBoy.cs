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

    // �A�j���[�V�����I�����ɌĂяo�����
    IEnumerator OnEastAnimationExit()
    {
        // �A�j���[�^�[�̎d�l��1�t���[���x�点�Ȃ���΂����Ȃ�
        yield return null;
        animator.SetBool("isEast", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.x += 1.0f;
        transform.position = pos;
    }

    // �A�j���[�V�����I�����ɌĂяo�����
    IEnumerator OnWestAnimationExit()
    {
        // �A�j���[�^�[�̎d�l��1�t���[���x�点�Ȃ���΂����Ȃ�
        yield return null;
        animator.SetBool("isWest", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.x -= 1.0f;
        transform.position = pos;
    }

    // �A�j���[�V�����I�����ɌĂяo�����
    IEnumerator OnNorthAnimationExit()
    {
        // �A�j���[�^�[�̎d�l��1�t���[���x�点�Ȃ���΂����Ȃ�
        yield return null;
        animator.SetBool("isNorth", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.z += 1.0f;
        transform.position = pos;
    }

    // �A�j���[�V�����I�����ɌĂяo�����
    IEnumerator OnSouthAnimationExit()
    {
        // �A�j���[�^�[�̎d�l��1�t���[���x�点�Ȃ���΂����Ȃ�
        yield return null;
        animator.SetBool("isSouth", false);
        audioSource.Play();
        animationType = AnimationType.Idle;
        var pos = transform.position;
        pos.z -= 1.0f;
        transform.position = pos;
    }
}
