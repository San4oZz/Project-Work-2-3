using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Ninject;

namespace WindowsFormsApp1
{


    public partial class MainForm : Form

    {

        // public BusLogic logic = new BusLogic(); //вторая лаба
        
        private IKernel ninjectKernel;
        public BusLogic logic;
        
        int selectStudIndex = 0;
        public Dictionary<string, int> gistogrammeGroup = new Dictionary<string, int>();
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            ninjectKernel = new StandardKernel(new SimpleConfigModule());
            logic = ninjectKernel.Get<BusLogic>();
            gistogrammeGroup = logic.Gystogramme();
            StudentList.Items.Clear();
            foreach (string item in logic.GetAll())
            {
                StudentList.Items.Add(item);
            }
            this.chart1.Series["Students"].Points.Clear();

            foreach (string item in gistogrammeGroup.Keys)
            {
                this.chart1.Series["Students"].Points.AddXY(item, gistogrammeGroup[item]);
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm frm2 = new AddForm(this);
            frm2.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentList.SelectedItems.Count <= 0)
            {
                return;
            }


            selectStudIndex = StudentList.SelectedIndex;

            logic.DeleteStudent(selectStudIndex + 1);
            StudentList.Items.Clear();
            gistogrammeGroup = logic.Gystogramme();
            foreach (string item in logic.GetAll())
            {
                StudentList.Items.Add(item);
            }
            this.chart1.Series["Students"].Points.Clear();

            foreach (string item in gistogrammeGroup.Keys)
            {
                this.chart1.Series["Students"].Points.AddXY(item, gistogrammeGroup[item]);
            }

        }

    }
}
    

