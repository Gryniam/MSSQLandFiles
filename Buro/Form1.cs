using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Buro
{
    public partial class Form1 : Form
    {
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        private SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void DisableButtons()
        {
            RefreshButton.Enabled = false;
            SearchDbButton.Enabled = false;
            SearchImage.Enabled = false;
            UPDButton.Enabled = false;
            OkButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
        public void EnableButtons()
        {
            RefreshButton.Enabled = true;
            SearchDbButton.Enabled = true;
            SearchImage.Enabled = true;
            UPDButton.Enabled = true;
            OkButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
        static string Connect;
        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("D:\\images");
            button2.Enabled = false;
            label5.BackColor = Color.Red;
            label5.Text = "Data Base Not Connected";
            DisconnectButton.Enabled = false;
            DisableButtons();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "mdf files (*.mdf)|*.mdf",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (open.ShowDialog()==DialogResult.OK)
            {
                 path = open.FileName;
                sqlCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");
                Connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
                sqlCon.Open();
            }
            if(sqlCon != null)
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    label5.BackColor = Color.Blue;
                    label5.Text = "Data Base Connected";
                    ConnectButton.Enabled = false;
                    DisconnectButton.Enabled = true;
                    DbJob.GridZapAll(ref table, sqlCon);
                    EnableButtons();

                }
                else
                {
                    label5.BackColor = Color.Red;
                    label5.Text = "Data Base Not Connected";
                    DisableButtons();
                }
            }
            else
            {
                label5.BackColor = Color.Red;
                label5.Text = "Data Base Not Connected";
                DisableButtons();
            }
        }
        public void ProtectAdd()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (AddNameBox.Text != null && AddColorBox.Text != null && AddWeightBox.Text != null && AddTimeBox.Text != null && AddPlaceBox.Text != null && (float.TryParse(AddWeightBox.Text, out float k)))
            { button2.Enabled = true;}
            else
            {button2.Enabled = false;}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(!(float.TryParse(AddWeightBox.Text, out float t))){
                MessageBox.Show("Поле ваги заповнене некоректно!");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                string Path;
                string Path2;
                OpenFileDialog open = new OpenFileDialog
                {
                    InitialDirectory = "c:\\",
                    Filter = "*png files (*.png)|*.png|jpeg files(*.jpeg)|*.jpeg| jpg files(*.jpg)|*.jpg",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Path = open.FileName;
                    Random rand = new Random();
                    int v = rand.Next() % 10000;
                    string value = v.ToString();
                    Path2 = "D:\\images\\" + AddNameBox.Text + "_" + AddColorBox.Text + "_" + value + ".jpeg";
                    FileInfo fl = new FileInfo(Path);
                    fl.CopyTo(Path2);
                    DbJob.AddToSql(ref AddNameBox, ref AddColorBox, ref AddWeightBox, ref AddTimeBox, ref AddPlaceBox, ref Path2, sqlCon);
                    DbJob.GridZapAll(ref table, sqlCon);
                    MessageBox.Show("Значення додано");
                    addtextclear();
                }
            }
        }
        public void addtextclear()
        {
            AddNameBox.Clear();
            AddColorBox.Text = "";
            AddWeightBox.Clear();
            AddTimeBox.Clear();
            AddPlaceBox.Clear();
        }
        public void searchtextclear()
        {
            SearchVBox.Text = "";
            ParametrBox.Clear();
            SearchId.Clear();
        }
        public void updtextclear()
        {
            RedId.Clear();
            UpdName.Clear();
            UpdColor.Clear();
            UpdWeight.Clear();
            UpdPlace.Clear();
            UpdTime.Clear();
            PathBox.Clear();
        }
        private void AddNameBox_TextChanged(object sender, EventArgs e)
        {ProtectAdd();}
        private void button1_Click(object sender, EventArgs e)
        { }
        private async void SearchImage_Click(object sender, EventArgs e)
        {
            string Path = null;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (!(int.TryParse(SearchId.Text, out int k)))
            {
                MessageBox.Show("Введіть число");
            }
            else
            {
                int n = 0;
                n = int.Parse(SearchId.Text, formatter);
                string sqlEx = "SELECT * FROM Items WHERE Id = " + n;
                using (SqlConnection sqlconnect = new SqlConnection(Connect))
                {
                    sqlconnect.Open();
                    SqlCommand com = new SqlCommand(sqlEx, sqlconnect);
                    using(SqlDataReader reader = await com.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while(await reader.ReadAsync())
                            {
                                Path = reader.GetString(6);
                            }
                        }
                    }
                }
            }
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            try
            { pictureBox1.Image = Image.FromFile(Path);}
            catch (Exception ex)
            {label9.Text = "Foto not found";}
        }
        private void SearchDbButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (!ProtectDouble())
            {
                MessageBox.Show("При виборі поля 'Вага', потрібно вказати число");
            }
            else
            {
                string search;
                search = ReturnPole(ref SearchVBox);
                if(search != "Weight")
                {
                    (table.DataSource as DataTable).DefaultView.RowFilter = $"{search} like '%{ParametrBox.Text}%'";
                }
                else
                {
                    ParametrBox.Text = ParametrBox.Text.Replace(',', '.');
                    float n = 0;
                    n = float.Parse(ParametrBox.Text, formatter);
                    (table.DataSource as DataTable).DefaultView.RowFilter = $"{search} = {n}";
                }
            }
        }
        public bool ProtectDouble()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            float k;
            if (SearchVBox.Text == "Вага")
            {
                if(!(float.TryParse(ParametrBox.Text, out k)))
                { return false;}
                else
                {return true;}
            }
            else
            {return true;}
        }
        public string ReturnPole(ref ComboBox textbox)
        {
            switch (textbox.Text)
            {
                case "Ім'я предмету": return "Name";

                case "Колір": return "Color";

                case "Вага": return "Weight";

                case "Час знахідки": return "SearchTime";

                case "Місце знахідки": return "SearchPlace";

                default: return "Name";
            }

        }
        private void SearchVBox_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void ParametrBox_TextChanged(object sender, EventArgs e)
        { }
        private void RefreshButton_Click(object sender, EventArgs e)
        { DbJob.GridZapAll(ref table, sqlCon);}
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            int k;
            if(!(int.TryParse(DelId.Text, out k)))
            {
                MessageBox.Show("Для видалення по ключу введіть число");
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                try
                {
                    string path;
                    int n = 0;
                    n = int.Parse(DelId.Text, formatter);
                    string sqlEx = "SELECT * FROM Items WHERE Id = " + n;
                    using (SqlConnection sqlconn = new SqlConnection(Connect))
                    {
                        sqlconn.Open();
                        SqlCommand com = new SqlCommand(sqlEx, sqlconn);
                        using (SqlDataReader reader = await com.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    path = reader.GetString(6);
                                    FileInfo filek = new FileInfo(path);
                                    if (filek.Exists)
                                    {
                                        filek.Delete();
                                    }
                                }
                            }
                        }
                    }
                    DbJob.DellFromSql(ref DelId, sqlCon);
                    DbJob.GridZapAll(ref table, sqlCon);
                    DelId.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невірний ключ товару");
                }
            }
        }
        static bool searched = false;
        public string PathToChangeFoto;
        private async void OkButton_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(RedId.Text, out int k)))
            {
                MessageBox.Show("Вкажіть числове значення");
            }
            else
            {
                int n = 0;
                n = int.Parse(RedId.Text, formatter);
                string sqlEx = "SELECT * FROM Items WHERE Id = " + n;
                using (SqlConnection sqlcn = new SqlConnection(Connect))
                {
                    sqlcn.Open();
                    SqlCommand com = new SqlCommand(sqlEx, sqlcn);
                    using (SqlDataReader reader = await com.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                UpdName.Text = reader.GetString(1);
                                UpdColor.Text = reader.GetString(2);
                                UpdWeight.Text = reader.GetValue(3).ToString();
                                UpdTime.Text = reader.GetString(4);
                                UpdPlace.Text = reader.GetString(5);
                                PathBox.Text = reader.GetString(6);
                               
                            }
                        }
                    }
                }
            }
        }
        private void UPDButton_Click(object sender, EventArgs e)
        {
            UpdWeight.Text = UpdWeight.Text.Replace(",", ".");
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (UpdName.Text != "" && UpdColor.Text != "" && UpdWeight.Text != "" && UpdTime.Text != "" && UpdPlace.Text != "")
            {
                if(float.TryParse(UpdWeight.Text, out float h))
                {
                    if (!searched)
                    {
                        SqlCommand com = new SqlCommand("UPDATE Items SET Name = @Name, Color = @Color, Weight = @Weight, SearchTime = @SearchTime, SearchPlace = @SearchPlace, FilePath = @FilePath WHERE Id = @Id", sqlCon);
                        com.Parameters.AddWithValue("Id", int.Parse(RedId.Text));
                        com.Parameters.AddWithValue("Name", UpdName.Text);
                        com.Parameters.AddWithValue("Color", UpdColor.Text);
                        com.Parameters.AddWithValue("Weight", float.Parse(UpdWeight.Text));
                        com.Parameters.AddWithValue("SearchTime", UpdTime.Text);
                        com.Parameters.AddWithValue("SearchPlace", UpdPlace.Text);
                        com.Parameters.AddWithValue("FilePath", PathBox.Text);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        FileInfo f1 = new FileInfo(PathBox.Text);
                        if (f1.Exists)
                        {
                            f1.Delete();
                        }
                        Random rand = new Random();
                        FileInfo f2 = new FileInfo(FotoForChange.Text);
                        string value = rand.Next().ToString();
                        string  Path2 = "D:\\images\\" + UpdName.Text + "_" + UpdColor.Text + "_" + value + ".jpeg";
                        f2.CopyTo(Path2);
                        SqlCommand com = new SqlCommand("UPDATE Items SET Name = @Name, Color = @Color, Weight = @Weight, SearchTime = @SearchTime, SearchPlace = @SearchPlace, FilePath = @FilePath WHERE Id = @Id", sqlCon);
                        
                        com.Parameters.AddWithValue("Name", UpdName.Text);
                        com.Parameters.AddWithValue("Color", UpdColor.Text);
                        com.Parameters.AddWithValue("Weight", float.Parse(UpdWeight.Text));
                        com.Parameters.AddWithValue("SearchTime", UpdTime.Text);
                        com.Parameters.AddWithValue("SearchPlace", UpdPlace.Text);
                        com.Parameters.AddWithValue("FilePath", Path2);
                        com.Parameters.AddWithValue("Id", int.Parse(RedId.Text));
                        com.ExecuteNonQuery();
                    }
                    UpdName.Clear();
                    UpdColor.Clear();
                    UpdWeight.Clear();
                    UpdTime.Clear();
                    UpdPlace.Clear();
                    PathBox.Clear();
                    FotoForChange.Clear();
                    DbJob.GridZapAll(ref table, sqlCon);
                    searched = false;
                    updtextclear();

                }
                else
                {MessageBox.Show("Введіть числове поле");}  
            }
            else
            {}
        }
        private void label5_Click(object sender, EventArgs e)
        {}
        private void ChangeFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "*png files (*.png)|*.png|jpeg files(*.jpeg)|*.jpeg",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                FotoForChange.Text = open.FileName;
                searched = true;
            }

        }
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            addtextclear();
            searchtextclear();
            DelId.Clear();
            updtextclear();
            table.Columns.Clear();
            sqlCon.Close();
            sqlCon = null;
            Connect = null;
            DisableButtons();
            label5.BackColor = Color.Red;
            label5.Text = "Data Base Disconnected";
            DisconnectButton.Enabled = false;
            ConnectButton.Enabled = true;
        }
    }
}
