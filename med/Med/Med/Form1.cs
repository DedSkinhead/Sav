using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SqlClient;

namespace Med
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        public int indexRow;
        public Form1()
        {
            InitializeComponent();

            db.openConnection();
            SqlCommand cmd = new SqlCommand("Select FIO,DataR,NomerR,Adres,Inval,Pol,Class.Name_class From Patient right join Class on Class.Id_class=Patient.Id_class", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            using (DataTable DT = new DataTable())
            {
                adapter.Fill(DT);
                PatientData.DataSource = DT;
            }
            db.closeConnection();
        }
        public int GetIdPatient(int indexRow)
        {
           string FIO = PatientData.Rows[indexRow].Cells[0].Value.ToString();
            string DataR = PatientData.Rows[indexRow].Cells[2].Value.ToString();
            db.openConnection();
            SqlCommand cmd = new SqlCommand("Select Id_patient FROM Patient where FIO = @FIO and NomerR=@DataR",db.GetConnection());
            cmd.Parameters.AddWithValue("@FIO", FIO);
            cmd.Parameters.AddWithValue("@DataR", DataR);
            int qwe = (int)cmd.ExecuteScalar();
            db.closeConnection();
            return qwe;
        }

        public void CurrentCell()
        {
            this.indexRow = PatientData.CurrentCell.RowIndex;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CurrentCell();
            Form2 f = new Form2(GetIdPatient(indexRow));
            Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PatientData.RowCount; i++)
            {
                PatientData.Rows[i].Selected = false;
                for (int j = 0; j < PatientData.ColumnCount; j++)
                    if (PatientData.Rows[i].Cells[j].Value != null)
                        if (PatientData.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                        {
                            PatientData.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }

}
