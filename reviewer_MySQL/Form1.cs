using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO; //Import this because we need to attach an image to the database or program.

namespace reviewer_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start(); //Code for the TIMER
        }
        DataTable dbdataset; //Declare a global variable

        string Gender; //Declare a global variable (Code for RADIOBUTTON)
        string Country; //Declare a global variable (Code for CHECKBOXES)

        private void Form1_Load(object sender, EventArgs e)
        {
            //searchData("");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Code that holds the image
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            string Query = "insert into employeedb.employee_tbl(Eid,name,surname,age,Gender,DOB,Image) values (@Eid, @name, @surname, @age, @Gender, @DOB, @img);";
            //string Query = "insert into employeedb.employee_tbl (Eid,name,surname,age) values('" + this.Eid_txt.Text + "','" + this.Name_txt.Text + "','" + this.Surname_txt.Text + "','" + ageComboBox.SelectedItem + "');";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            cmdDataBase.Parameters.AddWithValue("@Eid", Eid_txt.Text);
            cmdDataBase.Parameters.AddWithValue("@name", Name_txt.Text);
            cmdDataBase.Parameters.AddWithValue("@surname", Surname_txt.Text);
            cmdDataBase.Parameters.AddWithValue("@age", this.ageComboBox.SelectedItem);
            cmdDataBase.Parameters.AddWithValue("@Gender", Gender);
            cmdDataBase.Parameters.AddWithValue("@DOB", this.dateTimePicker1.Text);
            cmdDataBase.Parameters.AddWithValue("@img", imageBt);


            try
            {
                conDataBase.Open();
                int affectedRows = cmdDataBase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Failed to save data.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MySqlDataReader myReader;
            //try
            //{
            //    conDataBase.Open();
            //    myReader = cmdDataBase.ExecuteReader();
            //    cmdDataBase.ExecuteNonQuery();
            //    MessageBox.Show("Saved");
            //    while (myReader.Read())
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            string Query = "update employeedb.employee_tbl set Eid='" + this.Eid_txt.Text + "',name='" + this.Name_txt.Text + "',surname='" + this.Surname_txt.Text + "',age='" + ageComboBox.SelectedItem + "', Gender='" + Gender + "', DOB='" + this.dateTimePicker1.Text + "' where Eid='" + this.Eid_txt.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            string Query = "delete from employeedb.employee_tbl where Eid='" + this.Eid_txt.Text + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewTableButton_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select Eid as 'Employee ID', Name as 'First Name', Surname as 'Last Name', Age as 'Age', Gender as 'Gender', DOB as 'Date of Birth' from employeedb.employee_tbl;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                //dbdataset.Columns.Add("Pic", Type.GetType("System.Byte[]"));
                //foreach(DataRow drow in dbdataset.Rows)
                //{
                //    drow["Pic"] = File.ReadAllBytes(Application.StartupPath  + @"\Image" + Path.GetFileName(RowNotInTableException[])
                //}
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Code for the TIMER 
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_Label.Text = dateTime.ToString();
            //timer1.Start(); - Put this code in the Initialize Component
        }

        //Code for the CHART BUTTON (LOAD CHART)
        private void loadChartButton_Click(object sender, EventArgs e)
        {
            //this.chart1.Series["Age"].Points.AddXY("Max", 33); //Pass 2 variables. X-axis - name. Y-axis - age.
            //this.chart1.Series["Score"].Points.AddXY("Max", 90); //Pass 2 variables. X-axis - name. Y-axis - age.

            //this.chart1.Series["Age"].Points.AddXY("Patrick", 50); //Pass 2 variables. X-axis - name. Y-axis - age.
            //this.chart1.Series["Score"].Points.AddXY("Patrick", 70); //Pass 2 variables. X-axis - name. Y-axis - age.

            //this.chart1.Series["Age"].Points.AddXY("Ira", 72); //Pass 2 variables. X-axis - name. Y-axis - age.
            //this.chart1.Series["Score"].Points.AddXY("Ira", 30); //Pass 2 variables. X-axis - name. Y-axis - age.

            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from employeedb.employee_tbl;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Age"].Points.AddXY(myReader.GetString("name"), myReader.GetInt32("Age")); //Define the series name and give the x and y variable.
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            string progressBar1 = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Eid_txt.Text = row.Cells["Employee ID"].Value.ToString();
                Name_txt.Text = row.Cells["First Name"].Value.ToString();
                Surname_txt.Text = row.Cells["Last Name"].Value.ToString();
                ageComboBox.SelectedItem = row.Cells["Age"].Value.ToString();
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void usaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Country = "USA";
        }

        private void italyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Country = "Italy";
        }

        //Code for CHOOSING AN IMAGE from your computer or PC
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString(); //This will copy the file path into the picPath string.
                textBox_image_path.Text = picPath; //Copy the path of the image.
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(dbdataset); //Pass the global variable (the variable you declared on the top)
            //DV.RowFilter = string.Format("name LIKE '%{0}%'", searchTextBox.Text); //Name is the column name from the database.
            //dataGridView1.DataSource = DV;
        }

        //Cpder for searching from the datagrid view
        public void searchData(string valueToSearch)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            string query = "SELECT * FROM employeedb.employee_tbl WHERE CONCAT (Eid, name, surname,age) like '%"+valueToSearch+"%'";
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdDataBase);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchTextBox.Text.ToString();
            searchData(valueToSearch);

            //string constring = "datasource=localhost;port=3306;username=root;password=Omaguing122102";
            //MySqlConnection conDataBase = new MySqlConnection(constring);
            //MySqlCommand cmdDataBase; 
            //MySqlDataReader myReader;
            //conDataBase.Open();
            ////string query = "SELECT * FROM employeedb.employee_tbl WHERE Eid=" + int.Parse(Eid_txt.Text);
            //cmdDataBase = new MySqlCommand(query, conDataBase);
            

            //myReader = cmdDataBase.ExecuteReader();
            //if(myReader.Read())
            //{
            //    Eid_txt.Text = myReader.GetString("Eid");
            //    Name_txt.Text = myReader.GetString("name");
            //}
            //conDataBase.Close();


            //MySqlCommand cmdDataBase = new MySqlCommand();
            //MySqlDataReader myReader;
            //myReader = cmdDataBase.ExecuteReader();

            //if(myReader.Read())
            //{
            //    Eid_txt.Text = myReader.GetString(1);
            //    Name_txt.Text = myReader.GetString(2);
            //    Surname_txt.Text = myReader.GetString(3);
            //    ageComboBox.SelectedItem = myReader.GetString(4);

            //}

        }
    }
}

