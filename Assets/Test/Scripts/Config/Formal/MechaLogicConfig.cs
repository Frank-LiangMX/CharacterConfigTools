using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaLogic", menuName = "ScriptableObjects/Formal/MechaLogic", order = 1)]
    public class MechaLogicConfig : ScriptableObject
    {
        [LabelText("�߼���������")]
        public List<LODLogicPartRule> LODLogicPartRule = new List<LODLogicPartRule>();
    }

    [System.Serializable]
    public class LODLogicPartRule
    {
        [LabelText("LOD�㼶")]
        public Keys LODLevel;
        [LabelText("��λ")]
        public MechaLogicPartEnum MechaLogicPart;

        [LabelText("����")]
        [ListDrawerSettings(DraggableItems = false, ShowPaging = true, ShowItemCount = true)]
        public LogicPart[] logicPart;
    }

    public enum MechaLogicPartEnum
    {
        [LabelText("����")]
        Mecha,
        [LabelText("��װ1")]
        Armed1,
        [LabelText("��װ2")]
        Armed2,
        [LabelText("��װ3")]
        Armed3,
        [LabelText("��װ4")]
        Armed4,
        [LabelText("��װ5")]
        Armed5
    }
    [System.Serializable]
    public struct LogicPart
    {
        [Indent]
        [LabelText("��������")]
        public string LogicPartName;

        [Indent]
        [LabelText("�߼�����ģ��")]
        public string LogicPartModel;
    }

}

