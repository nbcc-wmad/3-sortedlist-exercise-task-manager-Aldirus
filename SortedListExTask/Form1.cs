using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Samuel Oakes

namespace SortedListExTask
{
    public partial class Form1 : Form
    {
        Dictionary<DateTime, string> task = new Dictionary<DateTime, string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == string.Empty)
            {
                MessageBox.Show("You must add a task");
            }
            else if(task.ContainsKey(dtpTaskDate.Value))
            {
                MessageBox.Show("Cannot have more than 1 task per day");
            }
            else
            {
                task.Add(dtpTaskDate.Value, txtTask.Text);
                lstTasks.Items.Add(dtpTaskDate.Value);
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                lblTaskDetails.Text = task[Convert.ToDateTime(lstTasks.SelectedItem)];
            }
            else
            {
                lblTaskDetails.Text = string.Empty;
            }


        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("No tasks selected");
            }
            else
            {
                task.Remove(Convert.ToDateTime(lstTasks.SelectedItem));
                lstTasks.Items.Remove(lstTasks.SelectedItem);
            }

        }

        private void lblTaskDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
