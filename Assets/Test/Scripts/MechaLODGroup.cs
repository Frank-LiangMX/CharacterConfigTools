// AssetListExamplesComponent.cs
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteAlways]
public class MechaLODGroup : MonoBehaviour
{
    public MechaEffectConfig effectconfig;

    [ListDrawerSettings()]
    public List<LODStruct> LODGroup;

    [AssetList(AutoPopulate = true, Path = "Test/Global/")]
    //[FoldoutGroup("LOD Setting", expanded: false)]
    public List<ScriptableObject> MechaGlobalConfigs;



    [AssetList(AutoPopulate = true, Path = "Test/M1/")]
    public List<ScriptableObject> MechaFormalConfigs;
}

[System.Serializable]
public class LODStruct
{
    public Keys LODLevel;
    public UsingSceneEnum 使用场景;
    public Object 动作Rig约束;
    public Object 动作IK;
    public EffectModelEnum 特效模;
    public ShadowModelEnum 阴影模;
    public Object 逻辑部件;
    public Object 特效件;
    public LightDecalLayer 灯光贴花层级;
}

public class test1: MonoBehaviour
{
    public string a = "aaa";
}

//[CustomEditor(typeof(MechaLODGroup))]

//public class MechaLODGroupEditor : Editor
//{
//    public override void OnInspectorGUI()
//    {
//        MechaLODGroup mecha = target as MechaLODGroup;

//        mecha.MechaName = target.name;
//        mecha.MechaPath = AssetDatabase.GetAssetPath(target);
//        if(GUILayout.Button("...",GUILayout.Width(20)))
//        {

//        }

//        DrawDefaultInspector();
//    }
//}