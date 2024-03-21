using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med
{
    public partial class Form2 : Form
    {
        DataBase db = new DataBase();
        public int IdPatent;
        public Form2(int index)
        {
            InitializeComponent();
            this.IdPatent = index;

        }

        public Form2()
        {
            InitializeComponent();
        }
        //  private void button1_Click(object sender, EventArgs e)
        //  {
        //     db.openConnection();
        //     SqlCommand sqlCommand = new SqlCommand("Insert into MCD (Id_medmap) Values(Name_disease)", db.GetConnection//());
        //      db.closeConnection();
        // }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            db.openConnection();
            SqlCommand sqlCommand = new SqlCommand("Select max(Id_disease) from Disease", db.GetConnection());
            for (int i = 0; i <= (int)sqlCommand.ExecuteScalar(); i++)
            {
                SqlCommand sqlComand2 = new SqlCommand("Select Name_disease from Disease where Id_disease=@Id_disease", db.GetConnection());
                sqlComand2.Parameters.AddWithValue("@Id_disease", i);
                if (sqlComand2.ExecuteScalar() == null) { continue; }
                else

                    comboBox.Items.Add(sqlComand2.ExecuteScalar());

            }
            db.closeConnection();
            db.openConnection();
            SqlCommand cmd = new SqlCommand("Select Name_graft from Patient " +
                "right join Med_map on Med_map.Id_patient=Patient.Id_patient " +
                "right join VMD on VMD.Id_medmap=Med_map.Id_medmap " +
                "right join Graft on Graft.Id_graft=VMD.Id_graft " +
                "where Patient.Id_patient=@Id_patient ", db.GetConnection());
            cmd.Parameters.AddWithValue("@Id_patient", IdPatent);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            using (DataTable DT = new DataTable())
            {
                adapter.Fill(DT);
                GraftDate.DataSource = DT;
            }
            db.closeConnection();

            fio.Text = Select("FIO");
            dataR.Text = Select("DataR");

            telR.Text = Select("NomerR");
            adres.Text = Select("Adres");
            inval.Text = Select("Inval");
            pol.Text = Select("Pol");
            DateTime bday = Convert.ToDateTime(Select("DataR"));
            DateTime now = DateTime.Today;
            int age = now.Year - bday.Year;
            if (bday > now.AddYears(-age)) age--;
            voz.Text = age.ToString();
            db.openConnection();
            SqlCommand cmdFio = new SqlCommand("Select Class.Name_class  From Patient right join Class on Class.Id_class=Patient.Id_class where Id_patient=@Id_patient", db.GetConnection());
            cmdFio.Parameters.AddWithValue("@Id_patient", IdPatent);
            classs.Text = cmdFio.ExecuteScalar().ToString();

            db.closeConnection();
            db.openConnection();
            SqlCommand cmd2 = new SqlCommand("Select Name_disease, Physical_training, EFV from Patient " +
                "right join Med_map on Med_map.Id_patient=Patient.Id_patient " +
                "right join MCD on MCD.Id_medmap=Med_map.Id_medmap " +
                "right join Disease on Disease.Id_disease=MCD.Id_disease " +
                "where Patient.Id_patient=@Id_patient ", db.GetConnection());
            cmd2.Parameters.AddWithValue("@Id_patient", IdPatent);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            using (DataTable DT = new DataTable())
            {
                adapter2.Fill(DT);
                DiseaseDate.DataSource = DT;
            }
            db.closeConnection();
        }
        private string Select(string qwert)
        {
            db.openConnection();
            SqlCommand cmdFio = new SqlCommand($"Select {qwert} From Patient where Id_patient=@Id_patient", db.GetConnection());
            cmdFio.Parameters.AddWithValue("@Id_patient", IdPatent);
            string tyu;
            if (qwert == "DataR")
            {
                tyu = ((DateTime)cmdFio.ExecuteScalar()).ToShortDateString().ToString();

            }
            else
                tyu = cmdFio.ExecuteScalar().ToString();
            db.closeConnection();
            return tyu;
        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Hide();
            f.Show();
        }
    }
}
