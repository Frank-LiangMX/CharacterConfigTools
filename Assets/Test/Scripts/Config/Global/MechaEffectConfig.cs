using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "MechaLODEffectFile", menuName = "ScriptableObjects/Global/MechaEffectConfig", order = 1)]
public class MechaEffectConfig : ScriptableObject
{
    public List<LODEffectRule> LODEffectRule = new List<LODEffectRule>();
}

[System.Serializable]
public class LODEffectRule
{
    [LabelText("LOD�㼶")]
    public Keys LODLevel;
    [LabelText("��Чģ")]
    public EffectModelEnum EffectModel;
    [LabelText("��Ч�Ҳ�")]
    public EffectContainer EffectModule;
}

public enum EffectModelEnum
{
    [LabelText("��")]
    ��,
    [LabelText("ʹ��LOD0Ϊ��Чģ")]
    UsingLOD0,
    [LabelText("ʹ��LOD1Ϊ��Чģ")]
    UsingLOD1,
    [LabelText("ʹ��LOD2Ϊ��Чģ")]
    UsingLOD2,
    [LabelText("ʹ��LOD3Ϊ��Чģ")]
    UsingLOD3,
    [LabelText("ʹ��LOD4Ϊ��Чģ")]
    UsingLOD4
}

public enum EffectContainer
{
    [LabelText("ͨ��_��������Ǽ�")]
    General,
    [LabelText("��װװ���Ǽ�")]
    Armed
}