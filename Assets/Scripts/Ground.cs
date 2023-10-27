using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] GroundType groundType = GroundType.Initial;
    [SerializeField] GroundMaterials groundMaterials = null;

    MeshRenderer meshRenderer = null;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ForGroundCollider"))
        {
            if (groundType != GroundType.Player1Encampment)
            {
                groundType = GroundType.Player1Trajectory;
                meshRenderer.material = groundMaterials.GetMaterial(groundType);
            }
        }
    }
}
