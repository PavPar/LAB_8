using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_8;

namespace LAB_8
{
    public partial class AddValue : Form
    {
        public XMLSpeaker XMLIO;
        public AddValue()
        {
            InitializeComponent();
        }

        public void GetSpeaker(XMLSpeaker IO)
        {
            XMLIO = IO;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            XMLIO.writeToFile(XMLIO.CreateElement(textbox_course.Text, textbox_groupID.Text, textbox_lastName.Text, textbox_checkBookID.Text, textbox_study.Text, val_mark.Value.ToString()));
            MessageBox.Show("Запись добавлена!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
