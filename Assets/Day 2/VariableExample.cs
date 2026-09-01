using UnityEngine; //네임스페이스

public class VariableExample : MonoBehaviour //클래스
{
    void Start() //함수
    {
        // 처음 시작할 때 실행
        Debug.Log("Hello World");
    }

    void Update()
    {
        //게임 오브젝트가 매 프레임마다 실행
        Debug.unityLogger.Log("Executed");
    }
}
