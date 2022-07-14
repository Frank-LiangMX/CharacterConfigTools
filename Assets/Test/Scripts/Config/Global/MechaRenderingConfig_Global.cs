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
        [LabelText("ȫ�ֽ�ɫ��Ӱ����������")]
        public List<LODRenderingRule> LODRenderingRule = new List<LODRenderingRule>();
    }

    [System.Serializable]

    public class LODRenderingRule
    {
        [LabelText("LOD�㼶")]
        public Keys LODLevel;
        [LabelText("�ƹ������㼶")]
        public LightDecalLayerEnum LightDecalLayer;
        [LabelText("��Ӱģ")]
        public ShadowModelEnum ShadowModel;
        [LabelText("��ɫ�ƹ�")]
        public Object CharacterLight;
    }

    public enum ShadowModelEnum
    {
        [LabelText("ģ��������Ӱ")]
        UseModelItself,
        [LabelText("����Ӱ")]
        None,
        [LabelText("Բ�μ���ӰͶӰ")]
        CircleFake,
        [LabelText("ʹ��LOD3Ϊ��Ӱģ")]
        UseLOD3,
        [LabelText("ʹ��LOD1Ϊ��Ӱģ")]
        UseLOD1
    }

    public enum CharacterLightEnum
    {
        [LabelText("���ɿ�ƹ���")]
        FactoryLight,
        [LabelText("�ƹ���1")]
        Light1,
        [LabelText("��")]
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

