using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Student> Studentlist = new List<Student>();
        List<double> GradeList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.textBox1.Text;
                string student_id = this.textBox4.Text;
                string birthyear = this.textBox3.Text;
                string height = this.textBox2.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                Student student = new Student(name, student_id, birthyear, height, grade, branch);
                Studentlist.Add(student);

                BindingSource source = new BindingSource();
                source.DataSource = Studentlist;
                this.dataGridView1.DataSource= source; 

                foreach(var val in Studentlist)
                {
                    this.GradeList.Add(val.Grade);
                }
                double maxgrade=GradeList.Max();
                double mingrade=GradeList.Min();

                int allperson=Studentlist.Count();

                this.label11.Text=allperson.ToString();
                this.label9.Text=maxgrade.ToString();
                this.label7.Text = mingrade.ToString();
            }
            catch {
                return;
            }
            



        }
    }
}
