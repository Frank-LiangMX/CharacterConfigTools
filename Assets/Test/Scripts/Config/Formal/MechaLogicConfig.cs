using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaLogic", menuName = "ScriptableObjects/Formal/MechaLogic", order = 1)]
    public class MechaLogicConfig : ScriptableObject
    {
        [LabelText("逻辑部件配置")]
        public List<LODLogicPartRule> LODLogicPartRule = new List<LODLogicPartRule>();
    }

    [System.Serializable]
    public class LODLogicPartRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("部位")]
        public MechaLogicPartEnum MechaLogicPart;

        [LabelText("名称")]
        [ListDrawerSettings(DraggableItems = false, ShowPaging = true, ShowItemCount = true)]
        public LogicPart[] logicPart;
    }

    public enum MechaLogicPartEnum
    {
        [LabelText("机体")]
        Mecha,
        [LabelText("武装1")]
        Armed1,
        [LabelText("武装2")]
        Armed2,
        [LabelText("武装3")]
        Armed3,
        [LabelText("武装4")]
        Armed4,
        [LabelText("武装5")]
        Armed5
    }
    [System.Serializable]
    public struct LogicPart
    {
        [Indent]
        [LabelText("部件名称")]
        public string LogicPartName;

        [Indent]
        [LabelText("逻辑部件模型")]
        public string LogicPartModel;
    }

}

