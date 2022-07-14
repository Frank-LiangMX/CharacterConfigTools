using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;

namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaModel", menuName = "ScriptableObjects/Formal/MechaModel", order = 1)]
    public class MechaModelConfig : ScriptableObject
    {
        [LabelText("机甲模型配置")]
        public List<LODModelRule> LODLogicPartRule = new List<LODModelRule>();
    }

    [System.Serializable]
    public class LODModelRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("部位")]
        public MechaPart MechaPart;
        [LabelText("LED灯")]
        public Object LEDLight;


        private readonly string[] maskDrawerArr = new string[]
          {
            "Light Layer default",
            "Light Layer Player",
            "Light Layer Environment",
            "Light Layer 3",
            "Light Layer 4",
            "Light Layer 5",
            "Light Layer 6",
            "Light Layer 7",
            "Decal Layer default",
            "Decal Layer Player",
            "Decal Layer Environment",
            "Decal Layer 3",
            "Decal Layer 4",
            "Decal Layer 5",
            "Decal Layer 6",
            "Decal Layer 7",
            "Unused 16",
            "Unused 17",
            "Unused 18",
            "Unused 19",
            "Unused 20",
            "Unused 21",
            "Unused 22",
            "Unused 23",
            "Unused 24",
            "Unused 25",
            "Unused 26",
            "Unused 27",
            "Unused 28",
            "Unused 29",
            "Unused 30",
            "Unused 31",
          };

        int _FlagsMaskDrawer(int value, GUIContent label)
        {
            if (value != renderingLayerMask)
            {
                value = (int)renderingLayerMask;
            }
            var flags = UnityEditor.EditorGUILayout.MaskField(label, value, maskDrawerArr);
            return flags;
        }

#if UNITY_EDITOR
        [CustomValueDrawer(nameof(_FlagsMaskDrawer))]
#endif
        public uint renderingLayerMask = (1 << 0) + (1 << 1) + (1 << 9);

    }

    public enum MechaPart
    {
        [LabelText("机体")]
        Mecha,
        [LabelText("武装1")]
        Armed1,
        [LabelText("武装2")]
        Armed2,
        [LabelText("武装3")]
        Armed3
    }
}

