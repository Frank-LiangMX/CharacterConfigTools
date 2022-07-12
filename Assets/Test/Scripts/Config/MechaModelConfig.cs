using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaModelFile", menuName = "ScriptableObjects/Formal/MechaModelConfig", order = 1)]
public class MechaModelConfig : ScriptableObject
{
    public List<LODModelRule> LODLogicPartRule = new List<LODModelRule>();
}

[System.Serializable]
public class LODModelRule
{
    public Keys LOD�㼶;
    public MechaPart ��λ;
    public int ������������;
    public int LED��;
    public int ����;
}

public enum MechaPart
{
    ����,
    ��װ1,
    ��װ2,
    ��װ3
}