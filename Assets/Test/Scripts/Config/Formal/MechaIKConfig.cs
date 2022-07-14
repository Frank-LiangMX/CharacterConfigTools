using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaIK", menuName = "ScriptableObjects/Formal/MechaIK", order = 1)]
    public class MechaIKConfig : ScriptableObject
    {
        [LabelText("动作IK配置")]
        public List<LODActionIKRule> LODActionIKRule = new List<LODActionIKRule>();
    }

    [System.Serializable]
    public class LODActionIKRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("部位")]
        public MechaPart MechaPart;
        [LabelText("配置项")]
        public Object ActionIK;
    }
}

