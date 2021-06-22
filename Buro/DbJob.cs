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
using System.Globalization;

namespace Buro
{
    class DbJob
    {
        static IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        public static void AddToSql(ref TextBox namebox, ref ComboBox colorbox, ref TextBox weightbox, ref TextBox searchbox, ref TextBox placebox,ref string path ,SqlConnection sq)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string s = weightbox.Text;
            s = s.Replace(',', '.');
            //weightbox.Text.Replace(',', '.');
            float g = float.Parse(s);
            if (searchbox.Text == "")
            {
                searchbox.Text = "Невідомо";
            }
            if (placebox.Text == "")
            {
                placebox.Text = "Невідомо";
            }
            SqlCommand command = new SqlCommand("INSERT INTO [Items] (Name, Color, Weight, SearchTime, SearchPlace, FilePath) VALUES (@Name, @Color, @Weight, @SearchTime, @SearchPlace, @FilePath)", sq);
            command.Parameters.AddWithValue("Name", namebox.Text);
            command.Parameters.AddWithValue("Color", colorbox.Text);
            command.Parameters.AddWithValue("Weight", g);
            command.Parameters.AddWithValue("SearchTime", searchbox.Text);
            command.Parameters.AddWithValue("SearchPlace", placebox.Text);
            command.Parameters.AddWithValue("FilePath", path);
            command.ExecuteNonQuery();
        }
        public static void DellFromSql(ref TextBox textbox, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand("DELETE FROM [Items] WHERE Id = @Id", conn);
            com.Parameters.AddWithValue("Id", int.Parse(textbox.Text));
            com.ExecuteNonQuery();
        }
        public static void GridZapAll(ref DataGridView grid, SqlConnection con)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * FROM Items", con);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            grid.DataSource = dataSet.Tables[0];
        }
    }
}
