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
    [LabelText("LOD层级")]
    public Keys LODLevel;
    [LabelText("部位")]
    public MechaLogicPartEnum MechaLogicPart;
    [LabelText("部件名称")]
    public string LogicPartName;
}

public enum MechaLogicPartEnum
{
    [LabelText("机体")]
    Mecha,
    [LabelText("武装1")]
    Armed1,
    [LabelText("武装2")]
    Armed2,
    [LabelText("武装3")]
    Armed3,
    [LabelText("武装4")]
    Armed4,
    [LabelText("武装5")]
    Armed5
}