using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Nilx
{
    public class NilxGraphEditor : EditorWindow
    {
        private NilxGraphView graphView;
        private ScrollView scrollView;

        [MenuItem("Nilx/Nilx Graph")]
        public static void OpenWindow()
        {
            var window = GetWindow<NilxGraphEditor>();
            window.titleContent = new GUIContent("Nilx Graph");
        }

        private void OnEnable()
        {
            graphView = new NilxGraphView();
            rootVisualElement.Add(graphView);
        }
    }
}
