using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaRigConfigFile", menuName = "ScriptableObjects/Formal/MechaRigConfig", order = 1)]
public class MechaActionRigConfig : ScriptableObject
{
    public List<LODRigRule> LODRigRule = new List<LODRigRule>();
}


[System.Serializable]
public class LODRigRule
{
    public Keys LOD�㼶;
    public MechaRigPart ��λ;
    public SettingPart ������;
    public int ����;
}

public enum Keys
{
    LOD0 = 0,
    LOD1 = 1,
    LOD2 = 2,
    LOD3 = 3,
    LOD4 = 4
}


public enum MechaRigPart
{
    ����,
    ��װ1,
    ��װ2
}

public enum SettingPart
{
    TransformationConstraint,
    LockedTrackConstraint,
    MultiAimConstraint,
    ParentConstraint,
    CopyPosition,
    CopyRotation,
    MultiRotationConstraint,
    TwoBoneIK,
    AimLockedTrackConstraint,
    CopyTransform
}