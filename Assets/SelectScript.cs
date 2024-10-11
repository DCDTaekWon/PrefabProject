using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public string message; // Inspector���� �޽����� ������ �� �ְ� ��

    private Button button; // ��ư ������Ʈ ����

    void Awake()
    {
        button = GetComponent<Button>(); // ���� ��ư ������Ʈ ��������
        button.onClick.AddListener(OnButtonClick); // Ŭ�� �̺�Ʈ ����
    }

    void OnButtonClick()
    {
        Debug.Log(message); // ��ư Ŭ�� �� �޽��� ���
    }
}


