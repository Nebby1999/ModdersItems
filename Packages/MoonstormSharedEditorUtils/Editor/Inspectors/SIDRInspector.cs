﻿using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using Moonstorm.EditorUtils.EditorWindows;
using RoR2EditorKit.Core.Inspectors;
using RoR2EditorKit.Core.Windows;

namespace Moonstorm.EditorUtils.Inspectors
{
    [CustomEditor(typeof(MSSingleItemDisplayRule))]
    public class SIDRInspector : ExtendedInspector
    {
        [OnOpenAsset]
        public static bool OpenEditor(int instanceID, int line)
        {
            if(Settings.InspectorSettings.GetOrCreateInspectorSetting(typeof(SIDRInspector)).isEnabled)
            {
                MSSingleItemDisplayRule obj = EditorUtility.InstanceIDToObject(instanceID) as MSSingleItemDisplayRule;
                if (obj != null)
                {
                    ExtendedEditorWindow.OpenEditorWindow<SIDREditorWindow>(obj, "Single Item Display Rule Set Editor Window");
                    return true;
                }
            }
            return false;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            if (InspectorEnabled && GUILayout.Button("Open Editor"))
            {
                ExtendedEditorWindow.OpenEditorWindow<SIDREditorWindow>(target, "Single Item Display Rule Set Editor Window");
            }
        }
    }
}