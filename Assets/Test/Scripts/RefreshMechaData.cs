using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CharacterLODConfig
{
    public class RefreshMechaData : Editor
    {
        public static MechaEffectConfig_Global globaleffectconfig; //特效配置文件
        public static MechaLODConfig_Global lodconfig; //
        public static MechaRenderingConfig_Global renderconfig;

        public static MechaEffectConfig effectConfig;
        public static MechaIKConfig IKconfig;
        public static MechaLogicConfig logicconfig;
        public static MechaModelConfig modelconfig;
        public static MechaRigConfig rigconfig;

        public static void Run(Object obj)
        {
            GameObject inst = (GameObject)PrefabUtility.InstantiatePrefab(obj);
            string path = AssetDatabase.GetAssetPath(obj);
            MechaLODGroup mecha = inst.GetComponent<MechaLODGroup>();

            Debug.Log("mecha全局配置:" + mecha.MechaGlobalConfigs.Count);
            //获取三个全局配置文件
            for (int i = 0; i < mecha.MechaGlobalConfigs.Count; i++)
            {
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaEffectConfig_Global))
                {
                    globaleffectconfig = (MechaEffectConfig_Global)mecha.MechaGlobalConfigs[i];
                }
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaLODConfig_Global))
                {
                    lodconfig = (MechaLODConfig_Global)mecha.MechaGlobalConfigs[i];
                }
                if (mecha.MechaGlobalConfigs[i].GetType() == typeof(MechaRenderingConfig_Global))
                {
                    renderconfig = (MechaRenderingConfig_Global)mecha.MechaGlobalConfigs[i];
                }
            }

            for (int i = 0; i < mecha.MechaFormalConfigs.Count; i++)
            {
                if (mecha.MechaFormalConfigs[i].GetType() == typeof(MechaLogicConfig))
                {
                    logicconfig = (MechaLogicConfig)mecha.MechaFormalConfigs[i];
                }
                if (mecha.MechaFormalConfigs[i].GetType() == typeof(MechaIKConfig))
                {
                    IKconfig = (MechaIKConfig)mecha.MechaFormalConfigs[i];
                }
                if (mecha.MechaFormalConfigs[i].GetType() == typeof(MechaModelConfig))
                {
                    modelconfig = (MechaModelConfig)mecha.MechaFormalConfigs[i];
                }
                if (mecha.MechaFormalConfigs[i].GetType() == typeof(MechaRigConfig))
                {
                    rigconfig = (MechaRigConfig)mecha.MechaFormalConfigs[i];
                }
                if (mecha.MechaFormalConfigs[i].GetType() == typeof(MechaEffectConfig))
                {
                    effectConfig = (MechaEffectConfig)mecha.MechaFormalConfigs[i];
                }
            }
            Debug.Log(globaleffectconfig);
            if (globaleffectconfig)
            {
                int LODCount = globaleffectconfig.LODEffectRule.Count; //获取LOD组件层数

                if (mecha.LODGroup.Count != LODCount) // 新增LODGroup数量为获取配置文件lod层级数
                {
                    mecha.LODGroup.Clear();
                    for (int i = 0; i < LODCount; i++)
                    {
                        LODStruct lod = new LODStruct();
                        lod.EffectPart = effectConfig.LODEffectRule[i].effectpart;
                        lod.actionIK = IKconfig.LODActionIKRule[i].ActionIK;
                        lod.LogicPart = logicconfig.LODLogicPartRule[i].logicPart;
                        lod.ActionRigConstraint = rigconfig.LODRigRule[i].ActionRigConstraint;
                        lod.UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                        lod.EffectModel = globaleffectconfig.LODEffectRule[i].EffectModel;
                        lod.LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                        mecha.LODGroup.Add(lod);
                    }
                }

                else if (mecha.LODGroup.Count == LODCount)
                {
                    for (int i = 0; i < mecha.LODGroup.Count; i++)
                    {
                        mecha.LODGroup[i].LogicPart = logicconfig.LODLogicPartRule[i].logicPart;
                        mecha.LODGroup[i].EffectPart = effectConfig.LODEffectRule[i].effectpart;
                        mecha.LODGroup[i].actionIK = IKconfig.LODActionIKRule[i].ActionIK;
                        mecha.LODGroup[i].ActionRigConstraint = rigconfig.LODRigRule[i].ActionRigConstraint;
                        mecha.LODGroup[i].UsingScene = lodconfig.LODLogicPartRule[i].UsingScene;
                        mecha.LODGroup[i].EffectModel = globaleffectconfig.LODEffectRule[i].EffectModel;
                        mecha.LODGroup[i].LightDecalLayer = renderconfig.LODRenderingRule[i].LightDecalLayer;
                    }
                }

                PrefabUtility.SaveAsPrefabAsset(inst, path);
                DestroyImmediate(inst);
            }
            else Debug.Log("No EffectConfigFile");
        }

        //public static MechaLODGroup GetFormalConfig(Object obj, MechaLODGroup lodgroup)
        //{
        //    string formalConfigPath = "Assets/Test/" + obj.name;

        //    Object[] allobjs = AssetDatabase.LoadAllAssetsAtPath(formalConfigPath);

        //    foreach(var allobj in allobjs)
        //    {
        //        if(allobj.GetType() == typeof(ScriptableObject))
        //        {
        //            lodgroup.MechaFormalConfigs.Add((ScriptableObject)allobj);
        //            return lodgroup;
        //        }
        //        return lodgroup;
        //    }
        //    return lodgroup;
        //}

    }

}

