using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class SleepingHours
    {
        public static void SleepingHoursMain()
        {
            int[,] sndfk = new int[2, 3]{
                {1,1,1},{2,3,4}
            };
            string[] str1 = new string[3];
            //str1 = {"s,ns,","","" };
            int[] x = { 1, 3, 4 };
            string[] kesj = { "sfnskf" };
            string str = "Sun 01:00-21:00\nMon 01:00-03:00\nMon 14:00-15:00\nTue 06:00-23:00\nWed 01:00-23:00\nThu 01:00-23:00\nFri 01:00-23:00\nSat 01:00-23:00";
            Console.WriteLine(str);
            var myList = str.Split('\n').ToList();
            Dictionary<int,string> dayMeetingScheduleDict = new Dictionary<int, string>();
            foreach (var item in myList)
            {
                string day = item.Substring(0, 3);
                int numericDay = 0;
                if(day == "Mon")
                {
                    numericDay = 1;
                }
                else if(day == "Tue")
                {
                    numericDay = 2;
                }
                else if(day == "Wed")
                {
                    numericDay = 3;
                }
                else if(day == "Thu")
                {
                    numericDay = 4;
                }
                else if(day == "Fri")
                {
                    numericDay = 5;
                }
                else if(day == "Sat")
                {
                    numericDay = 6;
                }
                else if(day == "Sun")
                {
                    numericDay = 7;
                }
                string start = Convert.ToInt32(item.Substring(4, 2)).ToString();
                string end = Convert.ToInt32(item.Substring(10, 2)).ToString();
                string currentInterval = start + "," + end;
                string existingInterval = "";
                if (dayMeetingScheduleDict.ContainsKey(numericDay))
                {
                    existingInterval = dayMeetingScheduleDict[numericDay];
                }
                if (!string.IsNullOrEmpty(existingInterval))
                {
                    dayMeetingScheduleDict[numericDay] = existingInterval + ";" + currentInterval;
                }
                else
                {
                    dayMeetingScheduleDict[numericDay] = currentInterval;
                }
                start = "";
                end = "";
            }

            int min = 0;
            //var dict = dayMeetingScheduleDict.OrderBy(x => x.Key);
            bool ContinuationExists = false;
            int prevContinuationMin = 0;
            //foreach (var item in dict)
            //{
            //    var val = item.Value;
            //    List<SleepingHoursInterval> hoursIntervals = new List<SleepingHoursInterval>();
            //    var myval = val.Split(';');
            //    foreach (var myvalItem in myval)
            //    {
            //        int strt = Convert.ToInt32(myvalItem.Split(',')[0].ToString());
            //        int ed = Convert.ToInt32(myvalItem.Split(',')[1].ToString());
            //        hoursIntervals.Add(new SleepingHoursInterval
            //        {
            //            start = strt,
            //            end = ed
            //        });

            //    }

            //    var orderList = hoursIntervals.OrderBy(x => x.start).ToList();
            //    if(orderList[0].start - 0 + prevContinuationMin > min)
            //    {
            //        min = prevContinuationMin + orderList[0].start - 0;
            //    }

            //    for (int i = 1; i < orderList.Count; i++)
            //    {
            //        if(orderList[i].start - orderList[i-1].end > min)
            //        {
            //            min = orderList[i].start - orderList[i - 1].end;
            //        }
            //    }

            //    if(24 - orderList[orderList.Count-1].end > min)
            //    {
            //        min = 24 - orderList[orderList.Count - 1].end;
            //        ContinuationExists = true;
            //    }
            //    prevContinuationMin = 24 - orderList[orderList.Count - 1].end;
            //    if(prevContinuationMin > 0)
            //    {
            //        ContinuationExists = true;
            //    }
            //}
        }
    }

    public class SleepingHoursInterval
    {
        public int start;
        public int end;
    }
}
