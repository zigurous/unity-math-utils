using UnityEditor;
using UnityEngine;

namespace Zigurous.Math.Editor
{
    [CustomPropertyDrawer(typeof(MathOperationNumber<,>), true)]
    public sealed class MathOperationNumberPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.BeginChangeCheck();

            float fullWidth = position.width;
            position.width = fullWidth * (1f/3f);

            SerializedProperty type = property.FindPropertyRelative("type");
            EditorGUI.PropertyField(position, type, GUIContent.none, true);

            position.x += position.width + 4f;
            position.width = fullWidth * (2f/3f) - 4f;

            switch ((MathOperationNumberType)type.enumValueIndex)
            {
                case MathOperationNumberType.Constant:
                    EditorGUI.PropertyField(position, property.FindPropertyRelative("constant"), GUIContent.none, true);
                    break;
                case MathOperationNumberType.Variable:
                    EditorGUI.PropertyField(position, property.FindPropertyRelative("variable"), GUIContent.none, true);
                    break;
                case MathOperationNumberType.Reference:
                    EditorGUI.PropertyField(position, property.FindPropertyRelative("reference"), GUIContent.none, true);
                    break;
            }

            if (EditorGUI.EndChangeCheck()) {
                property.serializedObject.ApplyModifiedProperties();
            }

            EditorGUI.EndProperty();
        }

    }

}
