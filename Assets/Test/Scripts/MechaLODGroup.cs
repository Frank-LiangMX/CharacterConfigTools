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
    [LabelText("��ȡ������Ϣ")]
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
        else Debug.Log("��FormalConfig");
    }
}

[System.Serializable]
public class LODStruct
{
    //[HideLabel]
    //public Keys LODLevel;

    [Indent]
    [LabelText("ʹ�ó���")]
    public UsingSceneEnum UsingScene;

    [Indent]
    [LabelText("����RigԼ��")]
    public Object ActionRigConstraint;

    [Indent]
    [LabelText("����IK")]
    public Object actionIK;

    [Indent]
    [LabelText("��Чģ")]
    public EffectModelEnum EffectModel;

    [Indent]
    [LabelText("��Ӱģ")]
    public ShadowModelEnum ShadowModel;

    [Indent]
    [LabelText("�߼�����")]
    public Object LogicPart;

    [Indent]
    [LabelText("��Ч��")]
    public Object EffectModule;

    [Indent]
    [LabelText("�ƹ������㼶")]
    public LightDecalLayerEnum LightDecalLayer;
}