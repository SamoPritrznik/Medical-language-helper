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
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Languages(Name_Eng, Name_Native) VALUES (@1, @2);";
                        comm.Parameters.AddWithValue("@1", foreign_name);
                        comm.Parameters.AddWithValue("@2", mother_name);
                        comm.ExecuteNonQuery();
                    }
                }
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
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT Name_Eng FROM languages;";
                        SQLiteDataReader rd = comm.ExecuteReader();

                        while (rd.Read())
                        {
                            listek.Add(rd.GetString(0).ToString());
                        }
                    }
                }
                
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
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM languages WHERE Name_Eng = @1;";
                        comm.Parameters.AddWithValue("@1", xname);
                        SQLiteDataReader rd = comm.ExecuteReader();

                        while (rd.Read())
                        {
                            id = rd.GetInt32(0);
                        }
                    }
                }
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
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE languages SET Name_Eng = @1, Name_Native = @2 WHERE id = @3;";
                        comm.Parameters.AddWithValue("@1", xname_eng);
                        comm.Parameters.AddWithValue("@2", xname_nat);
                        comm.Parameters.AddWithValue("@3", id);
                        comm.ExecuteNonQuery();
                    }
                }
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
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM languages WHERE id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //

        // Categories

        public List<String> get_categories()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT Description FROM Categories";
                        SQLiteDataReader rd = comm.ExecuteReader();
                        while (rd.Read())
                        {
                            listek.Add(rd.GetString(0).ToString());
                        }
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            return listek;
        }

        public void new_category(string xdesc)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Categories(Description) VALUES(@1)";
                        comm.Parameters.AddWithValue("@1", xdesc);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public int get_category_id(string xdesc)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Categories WHERE Description = @1";
                        comm.Parameters.AddWithValue("@1", xdesc);
                        SQLiteDataReader rd = comm.ExecuteReader();
                        while (rd.Read())
                        {
                            id = rd.GetInt32(0);
                        }
                        
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            return id;
        }

        public void new_translation_cat_lan(string trans, int lan_id, int cat_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Categories_Languages(Category_id, Language_id, Text) VALUES (@1, @2, @3)";
                        comm.Parameters.AddWithValue("@1", cat_id);
                        comm.Parameters.AddWithValue("@2", lan_id);
                        comm.Parameters.AddWithValue("@3", trans);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //

        // Types

        //

        // Questions

        //
    }

}
