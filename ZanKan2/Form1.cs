using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Collections;

namespace ZanKan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (System.Diagnostics.EventLog.Exists("System", "."))
            {
                ZangyoManage zangyoMng = new ZangyoManage(new TimeSpan(17, 00, 00),
                                                            new TimeSpan(2, 30, 00),
                                                            new TimeSpan(0, 15, 00));

                zangyoMng.Init("System", ".", "Kernel-General", DateTime.Today);

                zangyoMng.CalcZangyo();
                zangyoMng.CalcNakanukiZangyo(false);


                List<EventLogEntry> entryArray = zangyoMng.GetEventLog();
                
                foreach(EventLogEntry entry in entryArray)
                {
                    zangyoDataGrid.Rows.Add(entry.TimeGenerated.ToString(),
                                            )
                }

                TimeSpan totalZangyoTime = zangyoMng.getTotalZangyoTime();
                TimeSpan totalNakanukiZangyoTime = zangyoMng.getTotalNakanukiZangyoTime();
               
                totalZangyoNum.Text = totalZangyoTime.Hours.ToString() +
                                        ":" +
                                        totalZangyoTime.Minutes.ToString();
                totalZangyoNakanukiNum.Text = totalNakanukiZangyoTime.Hours.ToString() +
                                                 ":" +
                                                 totalNakanukiZangyoTime.Minutes.ToString();


                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
