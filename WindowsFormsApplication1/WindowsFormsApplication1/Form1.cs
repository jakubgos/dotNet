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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlConnection connection;

        public Form1()
        {

            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\git\\dotNet\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database1.mdf;Integrated Security=True");
            InitializeComponent();

            showAndRefreshDataView();
        }

        private void button1_Click_1(object sender, EventArgs e) //Add klient
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO klienci (nazwa, piorytet) VALUES (@nazwa, @piorytet)";

            command.Parameters.AddWithValue("@nazwa", TBaddName.Text);
            command.Parameters.AddWithValue("@piorytet", TBaddPio.Value);

            executeCommand(command);

            showAndRefreshDataView();
        }

        private void showAndRefreshDataView()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from klienci";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            ds.Tables[0].DefaultView.RowFilter = string.Format("nazwa LIKE '%{0}%'", FiltrKlientName.Text);

            dataGridView1.DataSource = ds.Tables[0];


            //////////

            command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from produkty";

            adapter = new SqlDataAdapter(command);

            ds = new DataSet();

            adapter.Fill(ds);
            ds.Tables[0].DefaultView.RowFilter = string.Format("producent LIKE '%{0}%'", FiltrProducent.Text);

            dataGridViewProduct.DataSource = ds.Tables[0];



            ///

            command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from zamowienia";

            command.CommandText = "select zamowienia.Id, produkty.nazwa, klienci.nazwa  from zamowienia " +
            "join produkty on produkty.Id = zamowienia.produktId " +
            "join klienci on klienci.Id = zamowienia.klientId ";

              adapter = new SqlDataAdapter(command);

            ds = new DataSet();

            adapter.Fill(ds);

            dataGridViewZamowienia.DataSource = ds.Tables[0];

            //////

            CBProduct.DataSource = getNameFromDbTable("produkty"); ;
            CBProduct.ValueMember = "id";
            CBProduct.DisplayMember = "nazwa";

            CBklient.DataSource = getNameFromDbTable("klienci"); ;
            CBklient.ValueMember = "id";
            CBklient.DisplayMember = "nazwa";

        
        }

        private int executeCommand(SqlCommand command)
        {
          try
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
           }
            catch (Exception e) {
                connection.Close();
                MessageBox.Show("You can't do like this...", "NO!!",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              return 1;
            }

            return 0;

        }

        private void button2_Click(object sender, EventArgs e) //add product
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO produkty (nazwa, ilosc, producent, cena) VALUES (@nazwa, @ilosc, @producent, @cena)";

            command.Parameters.AddWithValue("@nazwa", TBaddNameProduct.Text);
            command.Parameters.AddWithValue("@ilosc", TBaddProductNoOf.Value);
            command.Parameters.AddWithValue("@producent", TBaddProducentProduct.Text);
            command.Parameters.AddWithValue("@cena", TBaddCena.Value);

            executeCommand(command);

            showAndRefreshDataView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO zamowienia (klientId, produktId, ilosc, data) VALUES (@klientId, @produktId, @ilosc, @data)";

            command.Parameters.AddWithValue("@klientId", CBklient.SelectedValue);
            command.Parameters.AddWithValue("@produktId", CBProduct.SelectedValue);
            command.Parameters.AddWithValue("@ilosc", ZamowienieAddIlosc.Value);
            command.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            executeCommand(command);

            showAndRefreshDataView();


        }

        private DataTable getNameFromDbTable(String tableName)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from "+tableName;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            return ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewZamowienia.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridViewZamowienia.SelectedRows)
                {
                    if (!item.IsNewRow)
                        if (deleteFromDb((int)dataGridViewZamowienia.Rows[item.Index].Cells["Id"].Value, "zamowienia") != 0 ) break; 
                }
            }
            showAndRefreshDataView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    if (!item.IsNewRow)
                        if (deleteFromDb((int)dataGridView1.Rows[item.Index].Cells["Id"].Value, "klienci") != 0) break;
                }
            }
            showAndRefreshDataView();
        }

 
        private int deleteFromDb(int value, string tabela)
        {
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM "+ tabela + " WHERE Id = @id";

            command.Parameters.AddWithValue("@id", value);

            return executeCommand(command);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProduct.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridViewProduct.SelectedRows)
                {
                    if (!item.IsNewRow)
                        if (deleteFromDb((int)dataGridViewProduct.Rows[item.Index].Cells["Id"].Value, "produkty") != 0) break;
                }
            }
            showAndRefreshDataView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM zamowienia";
            executeCommand(command);
            command.CommandText = "DELETE FROM klienci";
            executeCommand(command);
            command.CommandText = "DELETE FROM produkty";
            executeCommand(command);

            showAndRefreshDataView();
        }

        private void FiltrKlientName_TextChanged(object sender, EventArgs e)
        {
            showAndRefreshDataView();
        }

        private void FiltrProducent_TextChanged(object sender, EventArgs e)
        {
            showAndRefreshDataView();
        }
    }
}
