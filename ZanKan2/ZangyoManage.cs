using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Collections;

namespace ZanKan2
{
    class ZangyoManage
    {
        static private TimeSpan teiji = new TimeSpan(17, 30, 00);
        static private TimeSpan breakTime = new TimeSpan(00, 15, 00);
        static private TimeSpan nakanuki = new TimeSpan(02, 30, 00);

        static private EventLog eventLog = null;
        static private List<EventLogEntry> targetEventLog = new List<EventLogEntry>();

        static private TimeSpan totalZangyoTime = new TimeSpan();
        static private TimeSpan nakanukiTotalZangyoTime = new TimeSpan();

        static private List<TimeSpan> zangyoArray = new List<TimeSpan>();
        static private List<TimeSpan> nakanukiZangyoArray = new List<TimeSpan>();
        

        public ZangyoManage(TimeSpan argTeiji, TimeSpan argNakanuki, TimeSpan argBreakTime)
        {
            teiji = argTeiji;
            nakanuki = argTeiji;
            breakTime = argBreakTime;
        }

        public void Init(String logName, String machineName, String source, DateTime time)
        {
            eventLog = new EventLog(logName, machineName, source);

            foreach (EventLogEntry entry in eventLog.Entries)
            {
                if(time.Month == entry.TimeGenerated.Month && entry.InstanceId == 13) targetEventLog.Add(entry);

                System.DateTime entryTime = entry.TimeGenerated;
            }
        }

        public EventLog GetAllEventLog() { return eventLog; }
        public List<EventLogEntry> GetEventLog() { return targetEventLog; }

        public List<TimeSpan> CalcZangyo()
        {
            foreach (EventLogEntry entry in targetEventLog)
            {
                if (entry.TimeGenerated.TimeOfDay > teiji) zangyoArray.Add(entry.TimeGenerated.TimeOfDay - teiji);
            }
            return zangyoArray;
        }

        public List<TimeSpan> CalcNakanukiZangyo(Boolean reCalcFlag)
        {
            List<TimeSpan> tmpArray = new List<TimeSpan>();
            
            tmpArray = (reCalcFlag) ? this.CalcZangyo() : zangyoArray;

            foreach (TimeSpan time in tmpArray)
            {

                TimeSpan tmpNakanukiTotalZangyoTime = new TimeSpan();
                TimeSpan tmpTime = tmpNakanukiTotalZangyoTime = time;
                        
                while (tmpTime > new TimeSpan(00, 00, 00) || tmpTime > nakanuki)
                {
                    tmpTime -= nakanuki;
                    tmpNakanukiTotalZangyoTime -= breakTime;
                }

                nakanukiZangyoArray.Add(tmpNakanukiTotalZangyoTime);

            }
            return nakanukiZangyoArray;
        }


        public List<TimeSpan> getZangyoArray() { return zangyoArray; }
        public List<TimeSpan> getNakanukiZangyoArray() { return nakanukiZangyoArray; }

        public TimeSpan getTotalZangyoTime()
        {
            List<TimeSpan> tmpArray = this.getZangyoArray();
            
            foreach (TimeSpan time in tmpArray)
            {
                totalZangyoTime += time;       
            }
            return totalZangyoTime;
        }

        public TimeSpan getTotalNakanukiZangyoTime()
        {
            List<TimeSpan> tmpArray = this.getNakanukiZangyoArray();

            foreach (TimeSpan time in tmpArray)
            {
                nakanukiTotalZangyoTime += time;
            }
            return nakanukiTotalZangyoTime;
        }
    }
}
