// AssetListExamplesComponent.cs
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteAlways]
public class MechaLODGroup : MonoBehaviour
{
    [TabGroup("LOD0")]
    [HideLabel]
    public LODStruct lod0;

    [TabGroup("LOD1")]
    [HideLabel]
    public LODStruct lod1;

    [TabGroup("LOD2")]
    [HideLabel]
    public LODStruct lod2;

    [TabGroup("LOD3")]
    [HideLabel]
    public LODStruct lod3;

    [TabGroup("LOD4")]
    [HideLabel]
    public LODStruct lod4;

    [HideInInspector]
    public List<LODStruct> LODGroup;

    [FoldoutGroup("Config")]
    [AssetList(AutoPopulate = true, Path = "Test/Global/")]
    public List<ScriptableObject> MechaGlobalConfigs;

    [FoldoutGroup("Config")]
    //[AssetList(AutoPopulate = true, Path = "Test/M1/")]
    public List<ScriptableObject> MechaFormalConfigs;


    [Button(ButtonSizes.Large), GUIColor(0, 1, 0)]
    [LabelText("获取配置信息")]
    private void GetConfigData()
    {
        if (MechaFormalConfigs.Count > 0)
        {
            string path = AssetDatabase.GetAssetPath(this);
            Object obj = AssetDatabase.LoadAssetAtPath<Object>(path);
            Test.Run(obj);

            lod0 = LODGroup[0];
            lod1 = LODGroup[1];
            lod2 = LODGroup[2];
            lod3 = LODGroup[3];
            lod4 = LODGroup[4];
        }
        else Debug.Log("无FormalConfig");
    }
}

[System.Serializable]
public class LODStruct
{
    //[HideLabel]
    //public Keys LODLevel;

    [Indent]
    [LabelText("使用场景")]
    public UsingSceneEnum UsingScene;

    [Indent]
    [LabelText("动作Rig约束")]
    public Object ActionRigConstraint;

    [Indent]
    [LabelText("动作IK")]
    public Object actionIK;

    [Indent]
    [LabelText("特效模")]
    public EffectModelEnum EffectModel;

    [Indent]
    [LabelText("阴影模")]
    public ShadowModelEnum ShadowModel;

    [Indent]
    [LabelText("逻辑部件")]
    public Object LogicPart;

    [Indent]
    [LabelText("特效件")]
    public Object EffectModule;

    [Indent]
    [LabelText("灯光贴花层级")]
    public LightDecalLayerEnum LightDecalLayer;
}