using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaLOD_Global", menuName = "ScriptableObjects/Global/MechaLOD_Global", order = 1)]
    public class MechaLODConfig_Global : ScriptableObject
    {
        [LabelText("ȫ��LOD���뼰ʹ�ó�������")]
        public List<LODDistanceRule> LODLogicPartRule = new List<LODDistanceRule>();
    }

    [System.Serializable]

    public class LODDistanceRule
    {
        [LabelText("LOD�㼶")]
        public Keys LODLevel;
        [LabelText("ʹ�ó���")]
        public UsingSceneEnum UsingScene;
        [LabelText("LOD����")]
        public int LODDistance;
    }

    public enum UsingSceneEnum
    {
        [LabelText("������ɿ�")]
        Factory,
        [LabelText("����ս������")]
        BattleScene
    }
}
