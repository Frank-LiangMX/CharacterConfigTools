using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaLogicPartConfigFile", menuName = "ScriptableObjects/Formal/MechaLogicPartConfig", order = 1)]
public class MechaLogicPartConfig : ScriptableObject
{
    public List<LODLogicPartRule> LODLogicPartRule = new List<LODLogicPartRule>();
}

[System.Serializable]
public class LODLogicPartRule
{
    public Keys LOD�㼶;
    public MechaLogicPart ��λ;
}

public enum MechaLogicPart
{
    ����,
    ��װ1,
    ��װ2,
    ��װ3,
    ��װ4,
    ��װ5
}