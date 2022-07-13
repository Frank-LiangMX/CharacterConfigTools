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
    [LabelText("LOD层级")]
    public Keys LODLevel;
    [LabelText("使用场景")]
    public UsingSceneEnum UsingScene;
    [LabelText("LOD距离")]
    public int LODDistance;
}

public enum UsingSceneEnum
{
    [LabelText("局外格纳库")]
    Factory,
    [LabelText("局外战斗场景")]
    BattleScene
}