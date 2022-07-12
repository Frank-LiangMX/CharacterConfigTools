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
    public Keys LOD层级;
    public MechaLogicPart 部位;
}

public enum MechaLogicPart
{
    机体,
    武装1,
    武装2,
    武装3,
    武装4,
    武装5
}