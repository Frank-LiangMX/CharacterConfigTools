using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : Editor
{
    public static MechaEffectConfig effectconfig; //��Ч�����ļ�
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

            //��ȡ����ȫ�������ļ�
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

            int LODCount = effectconfig.LODEffectRule.Count; //��ȡLOD�������

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
                    mecha.LODGroup[i].LODLevel = lodconfig.LODLogicPartRule[i].LOD�㼶;
                    mecha.LODGroup[i].ʹ�ó��� = lodconfig.LODLogicPartRule[i].ʹ�ó���;
                    mecha.LODGroup[i].��Чģ = effectconfig.LODEffectRule[i].��Чģ;
                    mecha.LODGroup[i].�ƹ������㼶 = renderconfig.LODRenderingRule[i].�ƹ������㼶;
                }
            }

            PrefabUtility.SaveAsPrefabAsset(inst, path);
            DestroyImmediate(inst);
        }
    }

}

