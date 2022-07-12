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
    public Keys LOD�㼶;
    public EffectModelEnum ��Чģ;
    public EffectContainer ��Ч�Ҳ�;
}

public enum EffectModelEnum
{
    ��,
    ʹ��LOD0Ϊ��Чģ,
    ʹ��LOD1Ϊ��Чģ,
    ʹ��LOD2Ϊ��Чģ,
    ʹ��LOD3Ϊ��Чģ,
    ʹ��LOD4Ϊ��Чģ
}

public enum EffectContainer
{
    ͨ��_��������Ǽ�,
    ��װװ���Ǽ�
}