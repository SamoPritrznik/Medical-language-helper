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
        

        // Languages
        public void save_language(string mother_name, string foreign_name)
        {
            
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand(con);
                comm.CommandText = "INSERT INTO Languages(Name_Eng, Name_Native) VALUES (@1, @2);";
                comm.Parameters.AddWithValue("@1", foreign_name);
                comm.Parameters.AddWithValue("@2", mother_name);
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public List<String> get_languages()
        {
            List<String> listek = new List<String>();
            try
            {
                int i = 0;
                SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand(con);
                comm.CommandText = "SELECT Name_Eng FROM languages;";
                SQLiteDataReader rd = comm.ExecuteReader();
                
                while(rd.Read())
                {
                    listek.Add(rd.GetString(0).ToString());
                }
                comm.Dispose();
                con.Close();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return listek;
        }

        public int get_language_id(string xname)
        {
            int id = 0;
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand(con);
                comm.CommandText = "SELECT id FROM languages WHERE Name_Eng = @1;";
                comm.Parameters.AddWithValue("@1", xname);
                SQLiteDataReader rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    id = rd.GetInt32(0);
                }
                comm.Dispose();
                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }

        public void change_languages(string xname_eng, string xname_nat, int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand(con);
                comm.CommandText = "UPDATE languages SET Name_Eng = @1, Name_Native = @2 WHERE id = @3;";
                comm.Parameters.AddWithValue("@1", xname_eng);
                comm.Parameters.AddWithValue("@2", xname_nat);
                comm.Parameters.AddWithValue("@3", id);
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void delete_languages(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db");
                con.Open();
                SQLiteCommand comm = new SQLiteCommand(con);
                comm.CommandText = "DELETE FROM languages WHERE id = @1;";
                comm.Parameters.AddWithValue("@1", id);
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
            }
            catch (SQLiteException ex)
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
