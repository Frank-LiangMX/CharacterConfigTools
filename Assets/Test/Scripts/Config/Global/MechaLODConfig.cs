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
    public Keys LOD�㼶;
    public UsingSceneEnum ʹ�ó���;
    public int LOD����;
}

public enum UsingSceneEnum
{
    ������ɿ�,
    ����ս������
}