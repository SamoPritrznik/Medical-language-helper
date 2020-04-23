using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_project_real
{
    public partial class Question_form : Form
    {
        databases dat = new databases();

        public Question_form()
        {
            InitializeComponent();
            CmbBx_Type.Items.AddRange(dat.get_types().ToArray());
            CmbBx_Category.Items.AddRange(dat.get_categories().ToArray());
            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest_3.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_categories.Items.AddRange(dat.get_categories().ToArray());
            CmbBx_edit_quest_type2.Items.AddRange(dat.get_types().ToArray());
            CmbBx_edit_lan.Items.AddRange(dat.get_quest_trans().ToArray());

            CmBx_Answer_create_tran.Items.AddRange(dat.get_answers().ToArray());
            CmBx_Language_create_tran.Items.AddRange(dat.get_languages().ToArray());

            CmBx_question_create_con.Items.AddRange(dat.get_quest().ToArray());
            CmBx_answer_create_con.Items.AddRange(dat.get_answers().ToArray());

            CmBx_edit_Answer.Items.AddRange(dat.get_answers().ToArray());

            CmBx_answer_tran_edit.Items.AddRange(dat.get_answer_trans().ToArray());
            CmBx_Answer_edit_tran.Items.AddRange(dat.get_answers().ToArray());
            CmBx_Language_edit_tran.Items.AddRange(dat.get_languages().ToArray());

            CmBx_question_edit_con.Items.AddRange(dat.get_quest().ToArray());
            CmBx_answer_edit_con.Items.AddRange(dat.get_answers().ToArray());

            
        }

        private void Btn_save_quest_Click(object sender, EventArgs e)
        {
            CmbBx_Type.Items.Clear();
            CmbBx_edit_quest.Items.Clear();
            CmbBx_edit_quest_3.Items.Clear();

            dat.insert_quest(TxtBx_Quest.Text, dat.get_type_id(CmbBx_Type.SelectedItem.ToString()), dat.get_category_id(CmbBx_Category.SelectedItem.ToString()));

            CmbBx_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest_3.Items.AddRange(dat.get_quest().ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CmbBx_edit_lan.Items.Clear();
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.insert_quest_trans(TxtBx_lang_quest.Text, dat.get_quest_id(CmbBx_quest.SelectedItem.ToString()), dat.get_language_id(CmbBx_quest_lang.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_lan.Items.AddRange(dat.get_quest_trans().ToArray());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CmbBx_Type.Items.Clear();
            CmbBx_edit_quest.Items.Clear();
            CmbBx_edit_quest_3.Items.Clear();

            dat.update_quest(TxtBx_Desc.Text, dat.get_quest_id(CmbBx_edit_quest.SelectedItem.ToString()), dat.get_type_id(CmbBx_edit_quest_type2.SelectedItem.ToString()), dat.get_category_id(CmbBx_edit_categories.SelectedItem.ToString()));

            CmbBx_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest_3.Items.AddRange(dat.get_quest().ToArray());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CmbBx_edit_lan.Items.Clear();
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.update_quest_trans(TxtBx_quest_trans.Text, dat.get_quest_id(CmbBx_edit_quest_3.SelectedItem.ToString()), dat.get_language_id(CmbBx_edit_lan.SelectedItem.ToString()), dat.get_quest_trans_id(CmbBx_edit_quest_trans.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_lan.Items.AddRange(dat.get_quest_trans().ToArray());
        }

        private void Btn_delete_quest_Click(object sender, EventArgs e)
        {
            CmbBx_Type.Items.Clear();
            CmbBx_edit_quest.Items.Clear();
            CmbBx_edit_quest_3.Items.Clear();

            dat.delete_quest(dat.get_quest_id(CmbBx_edit_quest.SelectedItem.ToString()));

            CmbBx_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest.Items.AddRange(dat.get_quest().ToArray());
            CmbBx_edit_quest_3.Items.AddRange(dat.get_quest().ToArray());
        }

        private void Btn_delete_quest_lan_Click(object sender, EventArgs e)
        {
            CmbBx_edit_lan.Items.Clear();
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.delete_quest_trans_id(dat.get_quest_trans_id(CmbBx_edit_quest_trans.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_lan.Items.AddRange(dat.get_quest_trans().ToArray());
        }

        private void Btn_create_answ_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.insert_answer(Tx_create_answer.Text);

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_create_trans_answer_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.insert_answer_trans(Tx_create_answer_tran.Text, dat.get_answer_id(CmBx_Answer_create_tran.SelectedItem.ToString()), dat.get_language_id(CmBx_Language_create_tran.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_create_answ_lan_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.insert_conn_answer_quest(dat.get_quest_id(CmBx_question_create_con.SelectedItem.ToString()), dat.get_answer_id(CmBx_answer_create_con.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_sort_answ_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.update_answer(Tx_edit_answer.Text, dat.get_answer_id(CmBx_edit_Answer.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_delete_answ_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.delete_answer(dat.get_answer_id(CmBx_edit_Answer.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_sort_answ_lan_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.update_anwser_tran(Tx_edit_answer_tran.Text, dat.get_answer_id(CmBx_Answer_edit_tran.SelectedItem.ToString()) , dat.get_answer_trans_id(CmBx_answer_tran_edit.SelectedItem.ToString()), dat.get_language_id(CmBx_Language_edit_tran.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_delete_answ_lan_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.delete_answer_tran(dat.get_answer_trans_id(CmBx_answer_tran_edit.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_sort_answ_quest_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.update_conn_answer_quest(dat.get_quest_id(CmBx_question_edit_con.SelectedItem.ToString()), dat.get_answer_id(CmBx_answer_edit_con.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_delete_answ_quest_Click(object sender, EventArgs e)
        {
            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();

            dat.delete_conn_answer_quest(dat.get_quest_id(CmBx_question_edit_con.SelectedItem.ToString()), dat.get_answer_id(CmBx_answer_edit_con.SelectedItem.ToString()));

            CmBx_Answer_create_tran.Items.Clear();
            CmBx_Language_create_tran.Items.Clear();

            CmBx_question_create_con.Items.Clear();
            CmBx_answer_create_con.Items.Clear();

            CmBx_edit_Answer.Items.Clear();

            CmBx_answer_tran_edit.Items.Clear();
            CmBx_Answer_edit_tran.Items.Clear();
            CmBx_Language_edit_tran.Items.Clear();

            CmBx_question_edit_con.Items.Clear();
            CmBx_answer_edit_con.Items.Clear();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
