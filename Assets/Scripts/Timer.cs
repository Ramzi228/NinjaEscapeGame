using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Timer : MonoBehaviour
{

    /*
   private int sec = 0;
   private int min = 0;
   private static Text timerText;
   [SerializeField] Text textTimer2;
   [SerializeField] Text recordText;

   private int record = 0;




   private void Start()
   {

       timerText = GameObject.Find("TimerText").GetComponent<Text>();
       StartCoroutine(TimerFlow());
   }
   IEnumerator TimerFlow()
   {
       while (true)
       {
           if (sec == 59)
           {
               min++;
               sec = -1;
           }
           if (min * 60 + sec > record)
           {
               record = min * 60 + sec;
               recordText.text = record.ToString();

           }

           sec++;
           timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
           textTimer2.text = min.ToString("D2") + " : " + sec.ToString("D2");



           yield return new WaitForSeconds(1);

       }
   }



    */




    public float timeStart;
   public Text textTimer;
   [SerializeField] Text textTimer2;
   [SerializeField] Text recordText;
    private float _record;

    private void Start()
   {
       textTimer.text = timeStart.ToString("F2");
       textTimer2.text = timeStart.ToString("F2");
       _record = PlayerPrefs.GetFloat("Record");

    }

   private void Update()
   {
        PlayerPrefs.SetFloat("Record", _record);
        recordText.text = _record.ToString("F2");
        timeStart += Time.deltaTime;
       textTimer.text = timeStart.ToString("F2");
       textTimer2.text = timeStart.ToString("F2");

        if (timeStart > _record)
        {

            _record = timeStart;

        }

        YandexGame.NewLeaderboardScores("LiderBoardNinja", (int)_record);

    }
    

}