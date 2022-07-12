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
    public Keys LOD层级;
    public MechaPart 部位;
    public int 基础材质球数;
    public int LED灯;
    public int 面数;
}

public enum MechaPart
{
    机体,
    武装1,
    武装2,
    武装3
}