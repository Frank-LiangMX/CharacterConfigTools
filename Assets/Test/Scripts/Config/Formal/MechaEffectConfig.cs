using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaEffect", menuName = "ScriptableObjects/Formal/MechaEffect", order = 1)]
    public class MechaEffectConfig : ScriptableObject
    {
        [LabelText("特效件配置")]
        [ListDrawerSettings(DraggableItems = false, ShowPaging = true, ShowItemCount = true)]
        public List<LODEffectRule> LODEffectRule = new List<LODEffectRule>();
    }

    [System.Serializable]
    public class LODEffectRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;

        [LabelText("特效件")]
        [ListDrawerSettings(DraggableItems = false, ShowPaging = true, ShowItemCount = true)]
        public EffectPart[] effectpart;
    }

    [System.Serializable]
    public struct EffectPart
    {
        [Indent]
        [LabelText("特效件中文名")]
        public string EffectpartChinese;

        [Indent]
        [LabelText("特效件名称")]
        public string EffectpartName;
    }
}

