using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(fileName = "MechaRenderingConfigFile", menuName = "ScriptableObjects/Global/MechaRenderingConfig", order = 1)]
public class MechaRenderingConfig : ScriptableObject
{
    public List<LODRenderingRule> LODRenderingRule = new List<LODRenderingRule>();
}

[System.Serializable]
public class LODRenderingRule
{
    public Keys LOD�㼶;
    public LightDecalLayer �ƹ������㼶;
    public ShadowModelEnum ��Ӱģ;
    public CharacterLight ��ɫ�ƹ�;
}

public enum ShadowModelEnum
{
    ģ��������Ӱ,
    ����Ӱ,
    Բ�μ���ӰͶӰ,
    ʹ��LOD3Ϊ��Ӱģ,
    ʹ��LOD1Ϊ��Ӱģ
}

public enum CharacterLight
{
    ���ɿ�ƹ���,
    �ƹ���1,
    ��
}

[System.Flags]
public enum LightDecalLayer
{
    LightLayerDefault = 1,
    LightLayerPlayer = 2,
    DecalLayerDefault = 4,
    DacalLayerPlayer = 8,
}
