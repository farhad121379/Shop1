using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shop1
{
    public partial class Form1 : Form
    {
        List<kala> kalas = new List<kala>();


        //kala selectekala = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.kala' table. You can move, or remove it, as needed.
            //this.kalaTableAdapter.Fill(this.shopDataSet.kala);
            // dataGridView1.DataSource = kalaBindingSource;
            // TODO: This line of code loads data into the 'labry2DataSet.Madrak' table. You can move, or remove it, as needed.
            //  this.madrakTableAdapter.Fill(this.labry2DataSet.Madrak);
            /////////////////////////////
            ShowDB();

        }
        private void ShowDB()
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=shop;Integrated Security=true;");
            string cmd = $"select * from kala";

            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int rowID = Convert.ToInt16(reader[0]);
                string rowname = reader[1].ToString();
                string rowghimat = reader[2].ToString();
                string rowmojodi = reader[3].ToString();


                kala k = new kala();
                k.ID = rowID;
                k.name = rowname;
                k.ghimat = rowghimat;
                k.mojodi= rowmojodi;
               kalas.Add(k);
                //List<string> myList = new List<string>();
                //myList.Add("Some item");


            }



            connection.Close();


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = kalas.ToArray();
            //List<string> kalaList = new List<string>();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  int index = dataGridView1.CurrentCell.RowIndex;
            //txtID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //txtname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //txtprice.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            //txtmo.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //DialogResult result = form2.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    kalaTableAdapter.InsertQuery(int.Parse(form2.txtID.Text), form2.txtmo.Text, form2.txtname.Text, form2.txtprice.Text);
            //    kalaTableAdapter.Fill(shopDataSet.kala);
            //    MessageBox.Show("با موفقیت ثبت شد");
            //}


            //if (txtID.TextLength > 0 && txtmo.TextLength > 0 && txtname.TextLength > 0 && txtprice.TextLength > 0)
            //{
            //    kalaTableAdapter.InsertQuery(int.Parse(txtID.Text), txtmo.Text, txtname.Text, txtprice.Text);
            //    kalaTableAdapter.Fill(shopDataSet.kala);
            //    MessageBox.Show("با موفقیت ثبت شد");
            //}



            ///////////////
            ///


            // Register Student Table



            string cmd = "";
            SqlConnection connection =
                new SqlConnection("Data Source=.; Initial Catalog=shop;Integrated Security=true;");



            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();
            cmd = $"INSERT INTO [dbo].[kala] ([ID],[name] ,[ghimat],[mojodi]) VALUES";
            cmd += $"('{form2.txtID.Text.Trim()}','{form2.txtname.Text.Trim()}','{form2.txtprice.Text.Trim()}','{form2.txtmo.Text.Trim()}'}})";


            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            connection.Open();

           

            connection.Close();

            // Edit





            ShowDB();

           
        }


        private void btnedit_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            int index = dataGridView1.CurrentCell.RowIndex;
            form2.txtname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            form2.txtID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            form2.txtprice.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
          DialogResult result = form2.ShowDialog();

            ///////////////////////////////
            ///

            string cmd = "";
            SqlConnection connection =
                new SqlConnection("Data Source=.; Initial Catalog=shop;Integrated Security=true;");

            cmd = $"UPDATE [dbo].[kala]  SET ([ID],[name] ,[ghimat],[mojodi]) VALUES";
            cmd += $"('{form2.txtID.Text.Trim()}','{form2.txtname.Text.Trim()}','{form2.txtprice.Text.Trim()}','{form2.txtmo.Text.Trim()}'}})";


            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            connection.Open();



            connection.Close();

           




            ShowDB();





            //if (result == DialogResult.OK)
            //{
            //    kalaTableAdapter.UpdateQuery(form2.txtname.Text, form2.txtmo.Text, form2.txtprice.Text, int.Parse(form2.txtID.Text));
            //    kalaTableAdapter.Fill(shopDataSet.kala);
            //    MessageBox.Show("با موفقیت ثبت شد");

            //}
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int index = dataGridView1.CurrentRow.Index;
            string strID = dataGridView1.Rows[index].Cells[0].Value.ToString();
          DialogResult r = MessageBox.Show("آیا مطمئن هستید که می خواهید این مورد را حذف کنید؟", "حذف مورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string cmd = "";
            SqlConnection connection =
                new SqlConnection("Data Source=.; Initial Catalog=shop;Integrated Security=true;");

            cmd = $"Dletet [dbo].[kala]  SET ([ID],[name] ,[ghimat],[mojodi]) VALUES";
            cmd += $"('{form2.txtID.Text.Trim()}','{form2.txtname.Text.Trim()}','{form2.txtprice.Text.Trim()}','{form2.txtmo.Text.Trim()}'}})";


            SqlCommand command = new SqlCommand();
            command.CommandText = cmd;
            command.Connection = connection;
            connection.Open();



            connection.Close();
            ShowDB();

            //if (r == DialogResult.Yes)
            //{
            //    kalaTableAdapter.DeleteQuery(int.Parse(strID));
            //    kalaTableAdapter.Fill(shopDataSet.kala);
            //}

        }

        private void btnpak_Click(object sender, EventArgs e)
        {
            //txtID.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> dataList = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                    dataList.Add(row.Cells[0].Value.ToString());     // فرض می‌کنیم ستون اول داده‌ها را نگه می‌دارد
            }
            //Form2 form2 = new Form2();
            //form2.txtID.Text = ;
            //form2.txtmo.Text ;
            //form2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        class kala
        {
            public int ID { get; set; }
            public String name { get; set; }
            public String ghimat { get; set; }
            public String mojodi { get; set; }


        }
    }
}
