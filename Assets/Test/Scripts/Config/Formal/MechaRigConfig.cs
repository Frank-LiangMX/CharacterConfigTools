using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Rendering;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaRig", menuName = "ScriptableObjects/Formal/MechaRig", order = 1)]
    public class MechaRigConfig : ScriptableObject
    {
        [LabelText("动作Rig约束配置")]
        public List<LODRigRule> LODRigRule = new List<LODRigRule>();
    }


    [System.Serializable]
    public class LODRigRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("部位")]
        public MechaRigPartEnum RigPart;
        [LabelText("配置项")]
        public Object ActionRigConstraint;
        //[LabelText("数量")]
        //public int Count;
    }

    public enum Keys
    {
        LOD0 = 0,
        LOD1 = 1,
        LOD2 = 2,
        LOD3 = 3,
        LOD4 = 4
    }


    public enum MechaRigPartEnum
    {
        [LabelText("机体")]
        Mecha,
        [LabelText("武装1")]
        Armed1,
        [LabelText("武装2")]
        Armed2
    }

    public enum SettingPartEnum
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
}

