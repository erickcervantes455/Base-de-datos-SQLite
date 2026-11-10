using System.Data.SQLite;

namespace Base_de_datos_SQLite
{
    public partial class Form1 : Form
    {
        //Agregamos la base de datos
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        //la base de datos se crea en la carpeta debug
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            datas_show();
        }
        private void datas_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cdm = new SQLiteCommand(stm, con);
            dr = cdm.ExecuteReader();
            while (dr.Read())
            {
                dgv.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20), id varchar(20))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("La base de datos no se pudo crear");
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cdm = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO test(name, id) VALUES(@name, @id)";
                string NAME = txtnombre.Text;
                string ID = txtid.Text;
                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);

                dgv.ColumnCount = 2;
                dgv.Columns[0].Name = "Nombre";
                dgv.Columns[1].Name = "ID";
                string[] row = new string[] { NAME, ID };
                dgv.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo insertar la informacion");
                return;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "UPDATE test SET id=@id WHERE name=@name";
                string NAME = txtnombre.Text;
                string ID = txtid.Text;
                cmd.Parameters.AddWithValue("@name", txtnombre);
                cmd.Parameters.AddWithValue("@id", txtid);
                cmd.ExecuteNonQuery();
                dgv.Rows.Clear();
                datas_show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo actualizar la informacion");
                return;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "DELETE FROM test WHERE name=@name";
                string NAME = txtnombre.Text;
                cmd.Parameters.AddWithValue("@name", txtnombre);
                cmd.ExecuteNonQuery();
                dgv.Rows.Clear();
                datas_show();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar la informacion");
                return;
            }
        }
    }
}