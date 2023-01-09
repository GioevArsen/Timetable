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
        
        public FormTimetable()
        {
            InitializeComponent();
        }

        private void checkBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            if (raspisanie[0] == "")
            {
                raspisanie[0] = "Понедельник - 3 пары"; ;
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
                raspisanie[1] = "Вторник - 3 пары";
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
                raspisanie[2] = "Среда - 4 пары";
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
                raspisanie[3] = "Четверг - 4 пары";
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
                raspisanie[4] = "Пятница - 3 пары";
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
                raspisanie[5] = "Суббота - 1 пара";
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
                raspisanie[6] = "Воскресенье - выходной";
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
