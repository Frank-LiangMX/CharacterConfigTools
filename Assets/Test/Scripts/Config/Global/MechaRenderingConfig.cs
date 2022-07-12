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
    public Keys LOD层级;
    public LightDecalLayer 灯光贴花层级;
    public ShadowModelEnum 阴影模;
    public CharacterLight 角色灯光;
}

public enum ShadowModelEnum
{
    模型自身阴影,
    无阴影,
    圆形假阴影投影,
    使用LOD3为阴影模,
    使用LOD1为阴影模
}

public enum CharacterLight
{
    格纳库灯光组,
    灯光组1,
    无
}

[System.Flags]
public enum LightDecalLayer
{
    LightLayerDefault = 1,
    LightLayerPlayer = 2,
    DecalLayerDefault = 4,
    DacalLayerPlayer = 8,
}
