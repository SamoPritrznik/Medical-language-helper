﻿using System;
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

        public int get_tran_category_id(string xdesc)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT cl.category_id FROM Categories_Languages cl INNER JOIN Categories c ON c.id = cl.category_id WHERE c.Description = @1";
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

        public int get_tran_language_id(string xdesc)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT cl.language_id FROM Categories_Languages cl INNER JOIN Languages l ON l.id = cl.language_id WHERE l.Name_Eng = @1";
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

        public List<String> get_cat_translation()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT c.Description FROM Categories c INNER JOIN Categories_Languages cl ON cl.category_id = c.id";
                        using (SQLiteDataReader rd = comm.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listek.Add(rd.GetString(0).ToString());
                            }
                            
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

        public List<String> get_lan_translation()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT l.Name_Eng FROM languages l INNER JOIN Categories_Languages cl ON cl.language_id = l.id";
                        using (SQLiteDataReader rd = comm.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listek.Add(rd.GetString(0).ToString());
                            }
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

        public void new_cat(string xname, int xid)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Categories SET Description = @1 WHERE id = @2";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", xid);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void new_trans(string trans, int cat, int lan)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Categories_Languages SET Text = @1 WHERE category_id = @2 AND language_id = @3;";
                        comm.Parameters.AddWithValue("@1", trans);
                        comm.Parameters.AddWithValue("@2", cat);
                        comm.Parameters.AddWithValue("@3", lan);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void del_cat(int xid)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Categories WHERE id = @1;";
                        comm.Parameters.AddWithValue("@1", xid);
                        comm.ExecuteNonQuery();
                        comm.CommandText = "DELETE FROM Categories_Languages WHERE category_id = @1;";
                        comm.Parameters.AddWithValue("@1", xid);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void del_trans(int cat, int lan)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Categories_Languages WHERE category_id = @1 AND language_id = @2;";
                        comm.Parameters.AddWithValue("@1", cat);
                        comm.Parameters.AddWithValue("@2", lan);
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

        public void create_type_quest(string xname)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Question_Types(Type) VALUES (@1)";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch(SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<String> get_types()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT Type FROM Question_Types";
                        SQLiteDataReader rd = comm.ExecuteReader();
                        while (rd.Read())
                        {
                            listek.Add(rd.GetString(0).ToString());
                        }
                    }
                }
            }
            catch(SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
            return listek;
        }

        public int get_type_id(string xname)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Question_Types WHERE Type = @1";
                        comm.Parameters.AddWithValue("@1", xname);
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



        public void update_type_quest(string xname, int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Question_Types SET Type = @1 WHERE id = @2";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_type_quest(int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Questions_Languages WHERE id = (SELECT l.id FROM Questions_Languages l INNER JOIN Questions q ON q.id = l.Question_id WHERE q.Question_Type_id = @1);";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Questions_Answers WHERE Question_id = (SELECT q.id FROM Questions q WHERE Question_Type_id = @1);";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Questions WHERE Question_Type_id = @1";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Question_Types WHERE id = @1";
                        comm.Parameters.AddWithValue("@1", id);
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

        // Questions

        public void insert_quest(string xname, int type_id, int category_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Questions(Question_Type_id, Description, Category_id) VALUES (@1, @2, @3)";
                        comm.Parameters.AddWithValue("@1", type_id);
                        comm.Parameters.AddWithValue("@2", xname);
                        comm.Parameters.AddWithValue("@3", category_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void insert_quest_trans(string xname, int quest_id, int lang_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Questions_Languages(Question_id, Language_id, text) VALUES (@1, @2, @3)";
                        comm.Parameters.AddWithValue("@1", quest_id);
                        comm.Parameters.AddWithValue("@2", lang_id);
                        comm.Parameters.AddWithValue("@3", xname);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<String> get_quest()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT description FROM Questions";
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

        public int get_quest_id(string xname)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Questions WHERE Description = @1";
                        comm.Parameters.AddWithValue("@1", xname);
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

        public void update_quest(string xname, int quest_id, int type, int category)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Questions SET description = @1 WHERE id = @2 AND Question_type_id = @3 AND Category_id = @4";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", quest_id);
                        comm.Parameters.AddWithValue("@2", type);
                        comm.Parameters.AddWithValue("@2", category);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_quest(int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Questions_Languages WHERE Question_id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Questions_Answers WHERE Question_id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Questions WHERE id = @1";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<String> get_quest_trans()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT text FROM Questions_languages";
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

        public int get_quest_trans_id(string xname)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Question_Languages WHERE Text = @1";
                        comm.Parameters.AddWithValue("@1", xname);
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

        public void update_quest_trans(string xname, int quest_id, int lang, int trans)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Questions SET text = @1 WHERE id = @2 AND Question_id = @3 AND Language_id = @4";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", trans);
                        comm.Parameters.AddWithValue("@2", quest_id);
                        comm.Parameters.AddWithValue("@2", trans);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_quest_trans_id(int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Questions_Languages WHERE id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void insert_answer(string xname)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Answers(Description) VALUES (@1)";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void insert_answer_trans(string xname, int answer_id, int lang_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Answers_Languages(Answer_id, Language_id, text) VALUES (@1, @2, @3)";
                        comm.Parameters.AddWithValue("@1", answer_id);
                        comm.Parameters.AddWithValue("@2", lang_id);
                        comm.Parameters.AddWithValue("@3", xname);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void insert_conn_answer_quest(int answer_id, int quest_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "INSERT INTO Questions_Answers(Question_id, Answer_id) VALUES (@1, @2)";
                        comm.Parameters.AddWithValue("@1", quest_id);
                        comm.Parameters.AddWithValue("@2", answer_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<String> get_answers()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT Description FROM Answers";
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

        public List<String> get_answer_trans()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT text FROM Answers_languages";
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

        public List<String> get_conn_answer()
        {
            List<String> listek = new List<String>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT description FROM Answers";
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

        public int get_answer_id(string xname)
        {
        int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Answers WHERE Description = @1";
                        comm.Parameters.AddWithValue("@1", xname);
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

        public void update_answer(string xname, int answer_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Answers SET description = @1 WHERE id = @2";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", answer_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_answer(int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Questions_Answers WHERE answer_id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Answers_languages WHERE answer_id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();

                        comm.CommandText = "DELETE FROM Answers WHERE id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void update_anwser_tran(string xname, int answer_id, int trans_id, int language_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Answers_Languages SET text = @1 WHERE id = @2 AND Answer_id = @3 AND Language_id = @4";
                        comm.Parameters.AddWithValue("@1", xname);
                        comm.Parameters.AddWithValue("@2", trans_id);
                        comm.Parameters.AddWithValue("@2", answer_id);
                        comm.Parameters.AddWithValue("@2", language_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_answer_tran(int id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE FROM Answers_languages WHERE id = @1;";
                        comm.Parameters.AddWithValue("@1", id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void update_conn_answer_quest(int quest_id, int answer_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "UPDATE Questions_Answers SET Answer_id = @1, Question_id = @2 WHERE Answer_id = @3 AND Question_id = @4";
                        comm.Parameters.AddWithValue("@1", answer_id);
                        comm.Parameters.AddWithValue("@2", quest_id);
                        comm.Parameters.AddWithValue("@3", answer_id);
                        comm.Parameters.AddWithValue("@4", quest_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void delete_conn_answer_quest(int quest_id, int answer_id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "DELETE Questions_Answers WHERE Answer_id = @1 AND Question_id = @2;";
                        comm.Parameters.AddWithValue("@1", answer_id);
                        comm.Parameters.AddWithValue("@2", quest_id);
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public int get_answer_trans_id(string xname)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("data source= questionsAnswers.db"))
                {
                    con.Open();
                    using (SQLiteCommand comm = new SQLiteCommand(con))
                    {
                        comm.CommandText = "SELECT id FROM Answers_Languages WHERE text = @1";
                        comm.Parameters.AddWithValue("@1", xname);
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
        //
    }

}
