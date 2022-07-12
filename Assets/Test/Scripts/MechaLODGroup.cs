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
    public UsingSceneEnum ʹ�ó���;
    public Object ����RigԼ��;
    public Object ����IK;
    public EffectModelEnum ��Чģ;
    public ShadowModelEnum ��Ӱģ;
    public Object �߼�����;
    public Object ��Ч��;
    public LightDecalLayer �ƹ������㼶;
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