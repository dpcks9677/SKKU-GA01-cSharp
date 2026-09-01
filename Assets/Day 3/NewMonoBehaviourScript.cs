using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1번 문제
        int answer1 = 0;
        

        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                answer1 += i;
            }
        }
        Debug.Log(answer1);
        
        // 2번 문제
        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                if (i != 5)
                {
                    Debug.Log($"{i} * {j} = {i*j}");
                }
            }
        }
    }
}
