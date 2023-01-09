using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class FormTimetable : Form
    {
        string[] raspisanie = { "", "", "", "", "", "", "" };
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        string[] lectures = { "3 пары", "3 пары", "4 пары", "4 пары", "3 пары", "1 пара", "Выходной" };

        public FormTimetable()
        {
            InitializeComponent();
        }


        private void checkBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[0] == "")
            {
                raspisanie[0] = days[0] + " - " + lectures[0];
            }
            else
            {
                raspisanie[0] = "";
            }
        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[1] == "")
            {
                raspisanie[1] = days[1] + " - " + lectures[1];
            }
            else
            {
                raspisanie[1] = "";
            }
        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[2] == "")
            {
                raspisanie[2] = days[2] + " - " + lectures[2];
            }
            else
            {
                raspisanie[2] = "";
            }
        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[3] == "")
            {
                raspisanie[3] = days[3] + " - " + lectures[3];
            }
            else
            {
                raspisanie[3] = "";
            }
        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[4] == "")
            {
                raspisanie[4] = days[4] + " - " + lectures[4];
            }
            else
            {
                raspisanie[4] = "";
            }
        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[5] == "")
            {
                raspisanie[5] = days[5] + " - " + lectures[5];
            }
            else
            {
                raspisanie[5] = "";
            }
        }

        private void checkBoxSunday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[6] == "")
            {
                raspisanie[6] = days[6] + " - " + lectures[6];
            }
            else
            {
                raspisanie[6] = "";
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBoxTimetable.Items.Clear();
            for (int i = 0; i < raspisanie.Length; i++)
            {
                if(raspisanie[i] != "")
                {
                    listBoxTimetable.Items.Add(raspisanie[i]);
                }
            }
        }
    }
}
