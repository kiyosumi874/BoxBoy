using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GroundType
{
    Initial,
    Player1Encampment, // êwín
    Player2Encampment,
    Player1Trajectory, // ãOê’
    Player2Trajectory
}

public class GroundMaterials : MonoBehaviour
{
    [SerializeField] List<Material> materials;

    public Material GetMaterial(GroundType type)
    {
        return materials[(int)type];
    }
}
