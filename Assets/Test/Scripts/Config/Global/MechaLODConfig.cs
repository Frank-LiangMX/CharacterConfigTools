using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "MechaLODConfigFile", menuName = "ScriptableObjects/Global/MechaLODConfig", order = 1)]
public class MechaLODConfig : ScriptableObject
{
    public List<LODDistanceRule> LODLogicPartRule = new List<LODDistanceRule>();
}

[System.Serializable]
public class LODDistanceRule
{
    [LabelText("LOD�㼶")]
    public Keys LODLevel;
    [LabelText("ʹ�ó���")]
    public UsingSceneEnum UsingScene;
    [LabelText("LOD����")]
    public int LODDistance;
}

public enum UsingSceneEnum
{
    [LabelText("������ɿ�")]
    Factory,
    [LabelText("����ս������")]
    BattleScene
}