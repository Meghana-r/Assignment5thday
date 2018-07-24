using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        StudentProfileEntities db = new StudentProfileEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            string roll = txtrollno.Text;

            int rolll = int.Parse(txtrollno.Text.ToString());

            string name = txtname.Text;

            string address = txtaddress.Text;

            string phone = txtphone.Text;

            string gender = "";

            if (rbfemale.Checked)

            {

                gender = "female";

            }

            if (rbmale.Checked)

            {

                gender = "male";

            }

            string department = cbdepartment.SelectedItem.ToString();

            string course = cbcourse.SelectedItem.ToString();

            string semester = cbsemester.SelectedItem.ToString();

            DateTime doj = DateTime.Parse(dtpdateof.Text.ToString());

            STUDPROF rs = new STUDPROF();

            rs.Address = address;

            rs.Course = course;

            rs.Dateof = doj;

            rs.Gender = gender;

            rs.Name = name;

            rs.phone = phone;

            rs.Rollno = rolll;

            rs.Semester = semester;

            rs.Department = department;

            db.STUDPROFs.Add(rs);

            var res = db.SaveChanges();

            if (res > 0)

            {

                MessageBox.Show("data inserted");

            }














        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            lbselect.Items.Clear();

            foreach (var t in db.STUDPROFs)

            {

                lbselect.Items.Add(t.Rollno);

                lbselect.Items.Add(t.Name);

                lbselect.Items.Add(t.Dateof);

                lbselect.Items.Add(t.Gender);

                lbselect.Items.Add(t.Department);

                lbselect.Items.Add(t.Course);

                lbselect.Items.Add(t.phone);

                lbselect.Items.Add(t.Course);

                lbselect.Items.Add(t.Address);

                lbselect.Items.Add(t.Semester);

                lbselect.Items.Add("**********************");







            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string address = txtaddress.Text;

            string phoneno = txtphone.Text;

            //combo box

            string department = cbdepartment.SelectedItem.ToString();

            string courses = cbcourse.SelectedItem.ToString();

            string semester = cbsemester.SelectedItem.ToString();

            int roll = int.Parse(txtrollno.Text.ToString());

            //checklistbox









            var olddata = db.STUDPROFs.Where(x => x.Rollno == roll).SingleOrDefault();

            olddata.Department = department;

            olddata.Course = courses;

            olddata.Semester = semester;

            olddata.Address = address;





            var res = db.SaveChanges();

            if (res > 0)

                MessageBox.Show("data updated");




        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int roll = int.Parse(txtrollno.Text.ToString());

            var del = (from t in db.STUDPROFs

                       where t.Rollno == roll

                       select t).SingleOrDefault();

            db.STUDPROFs.Remove(del);

            var res = db.SaveChanges();

            if (res > 0)

            {

                MessageBox.Show("data deleted");



            }
        }
    }
}
