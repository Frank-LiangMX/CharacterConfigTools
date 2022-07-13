using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : Editor
{
    public static MechaEffectConfig effectconfig; //特效配置文件
    public static MechaLODConfig lodconfig; //
    public static MechaRenderingConfig renderconfig;
    [MenuItem("Assets/Test")]
    public static void test()
    {
        var objs = Selection.objects;
        foreach(var obj in objs)
        {
            GameObject inst = (GameObject)PrefabUtility.InstantiatePrefab(obj);
            string path = AssetDatabase.GetAssetPath(obj);

            var mecha = inst.GetComponent<MechaLODGroup>();
            //Debug.Log(mecha.MechaGlobalConfigs.Count);

            //获取三个全局配置文件
            for (int i = 0; i < mecha.MechaGlobalConfigs.Count; i++)
            {
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaEffectConfig))
                {
                    effectconfig = (MechaEffectConfig)mecha.MechaGlobalConfigs[i];
                }
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaLODConfig))
                {
                    lodconfig = (MechaLODConfig)mecha.MechaGlobalConfigs[i];
                }
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaRenderingConfig))
                {
                    renderconfig = (MechaRenderingConfig)mecha.MechaGlobalConfigs[i];
                }

            }

            int LODCount = effectconfig.LODEffectRule.Count; //获取LOD组件层数

            if (mecha.LODGroup.Count != LODCount) // 新增LODGroup数量为获取配置文件lod层级数
            {
                mecha.LODGroup.Clear();
                for (int i = 0; i < LODCount; i++)
                {
                    LODStruct lod = new LODStruct();
                    //lod.LODLevel = lodconfig.LODLogicPartRule[i].LODLevel;
                    lod.UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                    lod.EffectModel = effectconfig.LODEffectRule[i].EffectModel;
                    lod.LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                    Debug.Log(lodconfig.LODLogicPartRule[i].LODLevel.ToString());
                    mecha.LODGroup.Add(lod);
                }
            }

            else if (mecha.LODGroup.Count == LODCount)
            {
                for (int i = 0; i < mecha.LODGroup.Count; i++)
                {
                    //mecha.LODGroup[i].LODLevel = lodconfig.LODLogicPartRule[i].LODLevel;
                    mecha.LODGroup[i].UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                    mecha.LODGroup[i].EffectModel = effectconfig.LODEffectRule[i].EffectModel;
                    mecha.LODGroup[i].LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                }
            }

            PrefabUtility.SaveAsPrefabAsset(inst, path);
            DestroyImmediate(inst);
        }
    }



    public static void Run(Object obj)
    {
        GameObject inst = (GameObject)PrefabUtility.InstantiatePrefab(obj);
        string path = AssetDatabase.GetAssetPath(obj);
        MechaLODGroup mecha = inst.GetComponent<MechaLODGroup>();

        Debug.Log(mecha.MechaGlobalConfigs.Count);
        //获取三个全局配置文件
        for (int i = 0; i < mecha.MechaGlobalConfigs.Count; i++)
        {
            if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaEffectConfig))
            {
                effectconfig = (MechaEffectConfig)mecha.MechaGlobalConfigs[i];
            }
            if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaLODConfig))
            {
                lodconfig = (MechaLODConfig)mecha.MechaGlobalConfigs[i];
            }
            if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaRenderingConfig))
            {
                renderconfig = (MechaRenderingConfig)mecha.MechaGlobalConfigs[i];
            }
        }
        Debug.Log(effectconfig);
        if (effectconfig)
        {
            int LODCount = effectconfig.LODEffectRule.Count; //获取LOD组件层数

            if (mecha.LODGroup.Count != LODCount) // 新增LODGroup数量为获取配置文件lod层级数
            {
                mecha.LODGroup.Clear();
                for (int i = 0; i < LODCount; i++)
                {
                    LODStruct lod = new LODStruct();
                    lod.UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                    lod.EffectModel = effectconfig.LODEffectRule[i].EffectModel;
                    lod.LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                    mecha.LODGroup.Add(lod);
                }
            }

            else if (mecha.LODGroup.Count == LODCount)
            {
                for (int i = 0; i < mecha.LODGroup.Count; i++)
                {
                    mecha.LODGroup[i].UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                    mecha.LODGroup[i].EffectModel = effectconfig.LODEffectRule[i].EffectModel;
                    mecha.LODGroup[i].LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                }
            }

            PrefabUtility.SaveAsPrefabAsset(inst, path);
            DestroyImmediate(inst);
        }
        else Debug.Log("No EffectConfigFile");
    }

    public static MechaLODGroup GetFormalConfig(Object obj, MechaLODGroup lodgroup)
    {
        string formalConfigPath = "Assets/Test/" + obj.name;

        Object[] allobjs = AssetDatabase.LoadAllAssetsAtPath(formalConfigPath);

        foreach(var allobj in allobjs)
        {
            if(allobj.GetType() == typeof(ScriptableObject))
            {
                lodgroup.MechaFormalConfigs.Add((ScriptableObject)allobj);
                return lodgroup;
            }
            return lodgroup;
        }
        return lodgroup;
    }

}

