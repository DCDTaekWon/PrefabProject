using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public string message; // Inspector에서 메시지를 설정할 수 있게 함

    private Button button; // 버튼 컴포넌트 저장

    void Awake()
    {
        button = GetComponent<Button>(); // 현재 버튼 컴포넌트 가져오기
        button.onClick.AddListener(OnButtonClick); // 클릭 이벤트 연결
    }

    void OnButtonClick()
    {
        Debug.Log(message); // 버튼 클릭 시 메시지 출력
    }
}


