using UnityEngine;

// 요일 열거형 선언
enum DayofWeek
{
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    Sunday
}

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class enumScript : MonoBehaviour
{
    // Enum: 열거형
    void Start()
    {
        DayofWeek today = DayofWeek.THURSDAY;

        if (today == DayofWeek.THURSDAY)
        {
            Debug.Log("Today is Thursday");
        }
        
        Season todaySeason = Season.Summer;

        if (todaySeason == Season.Summer)
        {
            Debug.Log("Today is in Summer");
        }
    }
}
