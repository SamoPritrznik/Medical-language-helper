using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace medical_project_real
{
    public class databases
    {
        public SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
        public SQLiteCommand comm;

        public void open()
        {
            con.Open();
            comm = new SQLiteCommand(con);
        }

        public void close()
        {
            comm.Dispose();
            con.Close();
        }

        // Languages
        public void save_language(string mother_name, string foreign_name)
        {
            try
            {
                comm.CommandText = "INSERT INTO languages(Name_Eng, Name_Native) VALUES (@1, @2);";
                comm.Parameters.AddWithValue("@1", foreign_name);
                comm.Parameters.AddWithValue("@2", mother_name);
                comm.ExecuteNonQuery();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //

        // Categories

        //

        // Types

        //

        // Questions

        //
    }

}
