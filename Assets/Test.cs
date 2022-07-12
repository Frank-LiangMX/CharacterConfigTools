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

            mecha.effectconfig = effectconfig;

            if (mecha.LODGroup.Count == 0)
            {
                for (int i = 0; i < LODCount; i++)
                {
                    mecha.LODGroup.Add(null);
                }
            }

            if (mecha.LODGroup.Count == LODCount)
            {
                for (int i = 0; i < LODCount; i++)
                {
                    mecha.LODGroup[i].LODLevel = lodconfig.LODLogicPartRule[i].LOD层级;
                    mecha.LODGroup[i].使用场景 = lodconfig.LODLogicPartRule[i].使用场景;
                    mecha.LODGroup[i].特效模 = effectconfig.LODEffectRule[i].特效模;
                    mecha.LODGroup[i].灯光贴花层级 = renderconfig.LODRenderingRule[i].灯光贴花层级;
                }
            }

            PrefabUtility.SaveAsPrefabAsset(inst, path);
            DestroyImmediate(inst);
        }
    }

}

