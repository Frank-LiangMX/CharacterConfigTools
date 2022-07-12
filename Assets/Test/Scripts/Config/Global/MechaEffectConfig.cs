using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaLODEffectFile", menuName = "ScriptableObjects/Global/MechaEffectConfig", order = 1)]
public class MechaEffectConfig : ScriptableObject
{
    public List<LODEffectRule> LODEffectRule = new List<LODEffectRule>();
}

[System.Serializable]
public class LODEffectRule
{
    public Keys LOD层级;
    public EffectModelEnum 特效模;
    public EffectContainer 特效挂槽;
}

public enum EffectModelEnum
{
    无,
    使用LOD0为特效模,
    使用LOD1为特效模,
    使用LOD2为特效模,
    使用LOD3为特效模,
    使用LOD4为特效模
}

public enum EffectContainer
{
    通用_机体基础骨架,
    武装装备骨架
}