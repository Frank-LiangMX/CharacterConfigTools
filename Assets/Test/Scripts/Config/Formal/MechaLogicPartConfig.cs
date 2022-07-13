using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "MechaLogicPartConfigFile", menuName = "ScriptableObjects/Formal/MechaLogicPartConfig", order = 1)]
public class MechaLogicPartConfig : ScriptableObject
{
    public List<LODLogicPartRule> LODLogicPartRule = new List<LODLogicPartRule>();
}

[System.Serializable]
public class LODLogicPartRule
{
    [LabelText("LOD�㼶")]
    public Keys LODLevel;
    [LabelText("��λ")]
    public MechaLogicPartEnum MechaLogicPart;
    [LabelText("��������")]
    public string LogicPartName;
}

public enum MechaLogicPartEnum
{
    [LabelText("����")]
    Mecha,
    [LabelText("��װ1")]
    Armed1,
    [LabelText("��װ2")]
    Armed2,
    [LabelText("��װ3")]
    Armed3,
    [LabelText("��װ4")]
    Armed4,
    [LabelText("��װ5")]
    Armed5
}