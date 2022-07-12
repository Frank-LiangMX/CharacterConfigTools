using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaLODConfigFile", menuName = "ScriptableObjects/Global/MechaLODConfig", order = 1)]
public class MechaLODConfig : ScriptableObject
{
    public List<LODDistanceRule> LODLogicPartRule = new List<LODDistanceRule>();
}

[System.Serializable]
public class LODDistanceRule
{
    public Keys LOD层级;
    public UsingSceneEnum 使用场景;
    public int LOD距离;
}

public enum UsingSceneEnum
{
    局外格纳库,
    局内战斗场景
}