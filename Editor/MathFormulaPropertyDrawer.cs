using UnityEditor;
using UnityEngine;

namespace Zigurous.Math.Editor
{
    [CustomPropertyDrawer(typeof(MathFormula<>), true)]
    public sealed class MathFormulaPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);

            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property, label, false);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;

            EditorGUI.BeginChangeCheck();

            if (property.isExpanded)
            {
                using (new EditorGUI.IndentLevelScope(1))
                {
                    SerializedProperty summationProperty = property.FindPropertyRelative("summation");
                    position = DrawProperty(position, summationProperty);

                    if (summationProperty.boolValue)
                    {
                        position = DrawProperty(position, property.FindPropertyRelative("summationMin"));
                        position = DrawProperty(position, property.FindPropertyRelative("summationMax"));
                    }

                    position = DrawProperty(position, property.FindPropertyRelative("operations"), true);
                }
            }

            if (EditorGUI.EndChangeCheck()) {
                property.serializedObject.ApplyModifiedProperties();
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = EditorGUIUtility.singleLineHeight;

            if (property.isExpanded)
            {
                height += EditorGUIUtility.standardVerticalSpacing;
                height += EditorGUIUtility.singleLineHeight;

                if (property.FindPropertyRelative("summation").boolValue)
                {
                    height += EditorGUIUtility.standardVerticalSpacing * 2;
                    height += EditorGUIUtility.singleLineHeight * 2;
                }

                height += EditorGUIUtility.standardVerticalSpacing;
                height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("operations"), true);
            }

            return height;
        }

        private Rect DrawProperty(Rect position, SerializedProperty property, bool includeChildren = true)
        {
            EditorGUI.PropertyField(position, property, includeChildren);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
            return position;
        }

    }

}
