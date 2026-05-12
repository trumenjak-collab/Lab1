using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Pomodoro
    {
        public Pomodoro() {
            WorkDuration = 25;
            RestDuration = 25;
            WorkInProgress = true;
            CurrentSeconds = ConvertMinutesToSeconds(WorkDuration);

        }
        public Pomodoro(int workDuration, int restDuration)
        {  WorkDuration = workDuration;
           RestDuration = restDuration;
           WorkInProgress = true;

        }


        public override string ToString()
        {
            int minutes = WorkDuration / 60; 
            int seconds = WorkDuration % 60;
            //minute.ToString("D2") + ":" + sekunde.ToString("D2");
            return minutes.ToString("D2") + ":" + seconds.ToString("D2");
         

        }

        public static int ConvertMinutesToSeconds(int minutes)
        {
            return minutes * 60:
        }

        public int WorkDuration { get; set; }
        public int RestDuration { get; set; }
        public bool WorkInProgress { get; set; }
    
        public int CurrentSeconds { get; set; }

    }
}
