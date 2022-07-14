using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Sirenix.OdinInspector;


namespace CharacterLODConfig
{
    [CreateAssetMenu(fileName = "MechaRendering_Global", menuName = "ScriptableObjects/Global/MechaRendering_Global", order = 1)]
    public class MechaRenderingConfig_Global : ScriptableObject
    {
        [LabelText("全局角色光影及贴花配置")]
        public List<LODRenderingRule> LODRenderingRule = new List<LODRenderingRule>();
    }

    [System.Serializable]

    public class LODRenderingRule
    {
        [LabelText("LOD层级")]
        public Keys LODLevel;
        [LabelText("灯光贴花层级")]
        public LightDecalLayerEnum LightDecalLayer;
        [LabelText("阴影模")]
        public ShadowModelEnum ShadowModel;
        [LabelText("角色灯光")]
        public Object CharacterLight;
    }

    public enum ShadowModelEnum
    {
        [LabelText("模型自身阴影")]
        UseModelItself,
        [LabelText("无阴影")]
        None,
        [LabelText("圆形假阴影投影")]
        CircleFake,
        [LabelText("使用LOD3为阴影模")]
        UseLOD3,
        [LabelText("使用LOD1为阴影模")]
        UseLOD1
    }

    public enum CharacterLightEnum
    {
        [LabelText("格纳库灯光组")]
        FactoryLight,
        [LabelText("灯光组1")]
        Light1,
        [LabelText("无")]
        None
    }

    [System.Flags]
    public enum LightDecalLayerEnum
    {
        LightLayerDefault = 1,
        LightLayerPlayer = 2,
        DecalLayerDefault = 4,
        DacalLayerPlayer = 8,
    }
}

