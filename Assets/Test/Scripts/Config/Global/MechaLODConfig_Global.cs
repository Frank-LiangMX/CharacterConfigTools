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
        [LabelText("全局LOD距离及使用场景配置")]
        public List<LODDistanceRule> LODLogicPartRule = new List<LODDistanceRule>();
    }

    [System.Serializable]

    public class LODDistanceRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("使用场景")]
        public UsingSceneEnum UsingScene;
        [LabelText("LOD距离")]
        public int LODDistance;
    }

    public enum UsingSceneEnum
    {
        [LabelText("局外格纳库")]
        Factory,
        [LabelText("局外战斗场景")]
        BattleScene
    }
}
