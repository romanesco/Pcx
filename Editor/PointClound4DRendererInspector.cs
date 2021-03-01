﻿// 4D extension of Pcx by Hiroyuki Inou:
// Pcx - Point cloud importer & renderer for Unity
// https://github.com/keijiro/Pcx

using UnityEngine;
using UnityEditor;

namespace Pcx4D
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(PointCloud4DRenderer))]
    public class PointCloud4DRendererInspector : Editor
    {
        SerializedProperty _sourceData;
        SerializedProperty _pointTint;
        SerializedProperty _pointSize;
        
        void OnEnable()
        {
            _sourceData = serializedObject.FindProperty("_sourceData");
            _pointTint = serializedObject.FindProperty("_pointTint");
            _pointSize = serializedObject.FindProperty("_pointSize");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_sourceData);
            EditorGUILayout.PropertyField(_pointTint);
            EditorGUILayout.PropertyField(_pointSize);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
