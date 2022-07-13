using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "MechaActionIKFile", menuName = "ScriptableObjects/Formal/MechaActionIKConfig", order = 1)]
public class MechaActionIKConfig : ScriptableObject
{
    public List<LODActionIKRule> LODActionIKRule = new List<LODActionIKRule>();
}

[System.Serializable]
public class LODActionIKRule
{
    [LabelText("LOD�㼶")]
    public Keys LODLevel;
    [LabelText("��λ")]
    public MechaPart MechaPart;
    [LabelText("������")]
    public Object Module;
}