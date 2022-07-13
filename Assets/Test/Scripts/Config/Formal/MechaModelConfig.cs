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
    [LabelText("LOD层级")]
    public Keys LODLevel;
    [LabelText("部位")]
    public MechaPart MechaPart;
    [LabelText("基础材质球数")]
    public Object MaterialCount;
    [LabelText("LED灯")]
    public Object LEDLight;
    [LabelText("面数")]
    public int FacesCount;
}

public enum MechaPart
{
    [LabelText("机体")]
    Mecha,
    [LabelText("武装1")]
    Armed1,
    [LabelText("武装2")]
    Armed2,
    [LabelText("武装3")]
    Armed3
}