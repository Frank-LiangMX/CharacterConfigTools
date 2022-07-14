using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaEffect_Global", menuName = "ScriptableObjects/Global/MechaEffect_Global", order = 1)]
    public class MechaEffectConfig_Global : ScriptableObject
    {
        [LabelText("全局特效配置")]
        public List<LODGlobalEffectRule> LODEffectRule = new List<LODGlobalEffectRule>();
    }

    [System.Serializable]
    public class LODGlobalEffectRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("特效模")]
        public EffectModelEnum EffectModel;
        [LabelText("特效挂槽")]
        public Object[] EffectModule;
    }

    public enum EffectModelEnum
    {
        [LabelText("无")]
        无,
        [LabelText("使用LOD0为特效模")]
        UsingLOD0,
        [LabelText("使用LOD1为特效模")]
        UsingLOD1,
        [LabelText("使用LOD2为特效模")]
        UsingLOD2,
        [LabelText("使用LOD3为特效模")]
        UsingLOD3,
        [LabelText("使用LOD4为特效模")]
        UsingLOD4
    }

    public enum EffectContainer
    {
        [LabelText("通用_机体基础骨架")]
        General,
        [LabelText("武装装备骨架")]
        Armed
    }
}

