using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "MechaModelFile", menuName = "ScriptableObjects/Formal/MechaModelConfig", order = 1)]
public class MechaModelConfig : ScriptableObject
{
    public List<LODModelRule> LODLogicPartRule = new List<LODModelRule>();
}

[System.Serializable]
public class LODModelRule
{
    [LabelText("LOD�㼶")]
    public Keys LODLevel;
    [LabelText("��λ")]
    public MechaPart MechaPart;
    [LabelText("������������")]
    public Object MaterialCount;
    [LabelText("LED��")]
    public Object LEDLight;
    [LabelText("����")]
    public int FacesCount;
}

public enum MechaPart
{
    [LabelText("����")]
    Mecha,
    [LabelText("��װ1")]
    Armed1,
    [LabelText("��װ2")]
    Armed2,
    [LabelText("��װ3")]
    Armed3
}