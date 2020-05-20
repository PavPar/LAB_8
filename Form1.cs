using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB_8
{


    public partial class Form1 : Form
    {
        private XMLSpeaker XMLIO;
        private TableCreator tbl;
        public Form1()
        {
            InitializeComponent();
            tbl = new TableCreator(dataGridView1);
            setControls(false);
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @".",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label_currFile.Text = openFileDialog1.FileName;
                string fileName = openFileDialog1.FileName;
                XMLIO = new XMLSpeaker(fileName);
                setControls(true);
                search_optn.Items.AddRange(new object[] {
                        "Поиск по курсу",
                        "Поиск по группе",
                        "Поиск по зач.книжке",
                        "Поиск по фамилии",
                        "Поиск по оценкам"});
                UpdateRows(XMLIO.GetAllData());
            }
            else
            {
                setControls(false);
            }
        }

        private void getXML_Click(object sender, EventArgs e)
        {
            UpdateRows(XMLIO.GetAllData());
        }

        private void UpdateRows(IEnumerable<XElement> res)
        {
            tbl.ClearRows();
            foreach (XElement element in res)
            {
                tbl.CreateRow(element.Element("course").Value.ToString(), element.Element("groupID").Value.ToString(), element.Element("lastName").Value.ToString(), element.Element("checkbookID").Value.ToString(), element.Element("study").Value.ToString(), element.Element("mark").Value.ToString());
            }
        }
        private void setControls(bool value)
        {
            btn_update.Enabled = value;
            search_optn.Enabled = value;
            textbox_searchbar.Enabled = value;
            btn_search.Enabled = value;
            btn_add.Enabled = value;
            btn_avg_course.Enabled = value;
            btn_avg_group.Enabled = value;
            btn_avg_study.Enabled = value;
            label_currFile.Text = "Файл не выбран";
        }

        private void btn_SetXML_Click(object sender, EventArgs e)
        {
            AddValue ValForm = new AddValue();
            ValForm.GetSpeaker(XMLIO);
            //ValForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChangeEvent);
            ValForm.Show();
            //XMLIO.writeToFile(XMLIO.CreateElement("test", "test", "test", "test", "test", "test"));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            switch (search_optn.SelectedIndex)
            {
                case 0:
                    {
                        UpdateRows(XMLIO.GetSpecificData("course", textbox_searchbar.Text));
                        return;
                    }
                case 1:
                    {
                        UpdateRows(XMLIO.GetSpecificData("groupID", textbox_searchbar.Text));
                        return;
                    }
                case 2:
                    {
                        UpdateRows(XMLIO.GetSpecificData("checkbookID", textbox_searchbar.Text));
                        return;
                    }
                case 3:
                    {
                        UpdateRows(XMLIO.GetSpecificData("lastName", textbox_searchbar.Text));
                        return;
                    }
                case 4:
                    {
                        UpdateRows(XMLIO.GetSpecificData("mark", textbox_searchbar.Text));
                        return;
                    }
            }
        }

        private void btn_avg_course_Click(object sender, EventArgs e)
        {
            ShowStat avgStat = new ShowStat();
            avgStat.SetData(XMLIO.getAVGMarks("course", "mark"), "course", "mark");
            avgStat.Show();
        }

        private void btn_avg_group_Click(object sender, EventArgs e)
        {
            ShowStat avgStat = new ShowStat();
            avgStat.SetData(XMLIO.getAVGMarks("groupID", "mark"), "groupID", "mark");
            avgStat.Show();
        }

        private void btn_avg_study_Click(object sender, EventArgs e)
        {
            ShowStat avgStat = new ShowStat();
            avgStat.SetData(XMLIO.getAVGMarks("study", "mark"), "study", "mark");
            avgStat.Show();
        }
    }
}
