using UnityEngine;
using UnityEngine.UIElements;

public class testScripts : MonoBehaviour
{
    private UIDocument uiDocument;

	private void Awake()
	{
		uiDocument = GetComponent<UIDocument>();
	}

	private void Start()
	{
		var rootVisualElement = uiDocument.rootVisualElement;
		
		if (rootVisualElement != null)
		{
			var textInputField = rootVisualElement.Q("First_Name_InputField");
			var textInput = textInputField.Q("unity-text-input");

			textInput.style.borderLeftWidth = 1;
			textInput.style.borderRightWidth = 1;
			textInput.style.borderTopWidth = 1;
			textInput.style.borderBottomWidth = 1;
			textInput.style.borderTopLeftRadius = 10;
			textInput.style.borderTopRightRadius = 10;
			textInput.style.borderBottomLeftRadius = 10;
			textInput.style.borderBottomRightRadius = 10;

			// 배경색 제거
			textInput.style.backgroundColor = new StyleColor(Color.clear);
		}
	}
}
