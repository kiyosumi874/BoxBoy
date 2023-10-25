using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBoy : MonoBehaviour
{
    static readonly Vector3 AxisPositionEast = new Vector3(0.5f, 0.5f, 0.0f); // ìå
    static readonly Vector3 AxisPositionWest = new Vector3(-0.5f, 0.5f, 0.0f); // êº
    static readonly Vector3 AxisPositionSouth = new Vector3(0.0f, 0.5f, -0.5f); // ìÏ
    static readonly Vector3 AxisPositionNorth = new Vector3(0.0f, 0.5f, 0.5f); // ñk

    [SerializeField] Transform axisTransform;
    [SerializeField] Transform boxTransform;


    float prevRotateZ = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            StartCoroutine(RotationCor());
        }
    }

    IEnumerator RotationCor()
    {
        prevRotateZ = axisTransform.rotation.z;
        while (true) 
        {
            var rotate = axisTransform.rotation;
            rotate.z += -0.01f;
            axisTransform.rotation = rotate;
            if (axisTransform.rotation.z < prevRotateZ - 90.0f)
            {
                var pos = boxTransform.transform.position;
                pos.x += -1.0f;
                boxTransform.transform.position = pos;
                pos.x += 2.0f;
                axisTransform.transform.position = pos;
                yield break;
            }
            yield return null;
        }
    }
}
