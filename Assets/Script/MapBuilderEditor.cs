using UnityEditor;
using UnityEngine;

namespace Script
{
    [CustomEditor(typeof(MapBuilder))]
    public class MapBuilderEditor: Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            MapBuilder myScript = (MapBuilder)target;
            if(GUILayout.Button("Build Map"))
            {
                myScript.Build();
            }
        }
    }
}