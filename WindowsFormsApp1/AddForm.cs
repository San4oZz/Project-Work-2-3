using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        MainForm mainForm;

        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            CenterToScreen();
            this.mainForm = mainForm;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            mainForm.logic.AddStudent(NameBox.Text, Speciality.Text, Group.Text);

            mainForm.StudentList.Items.Clear();
            foreach (string item in mainForm.logic.GetAll())
            {
                mainForm.StudentList.Items.Add(item);
            }
            mainForm.chart1.Series["Students"].Points.Clear();
            mainForm.gistogrammeGroup = mainForm.logic.Gystogramme();
            foreach (string item in mainForm.gistogrammeGroup.Keys)
            {
                mainForm.chart1.Series["Students"].Points.AddXY(item, mainForm.gistogrammeGroup[item]);
            }
            this.Hide();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
