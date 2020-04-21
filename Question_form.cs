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
            CmbBx_edit_lan.Items.AddRange(dat.get_languages().ToArray());
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
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.insert_quest_trans(TxtBx_lang_quest.Text, dat.get_quest_id(CmbBx_quest.SelectedItem.ToString()), dat.get_language_id(CmbBx_quest_lang.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
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
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.update_quest_trans(TxtBx_quest_trans.Text, dat.get_quest_id(CmbBx_edit_quest_3.SelectedItem.ToString()), dat.get_language_id(CmbBx_edit_lan.SelectedItem.ToString()), dat.get_quest_trans_id(CmbBx_edit_quest_trans.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
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
            CmbBx_quest_lang.Items.Clear();
            CmbBx_edit_quest_trans.Items.Clear();

            dat.delete_quest_trans_id(dat.get_quest_trans_id(CmbBx_edit_quest_trans.SelectedItem.ToString()));

            CmbBx_quest_lang.Items.AddRange(dat.get_quest_trans().ToArray());
            CmbBx_edit_quest_trans.Items.AddRange(dat.get_quest_trans().ToArray());
        }

        private void Btn_create_answ_Click(object sender, EventArgs e)
        {

        }

        private void Btn_create_trans_answer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_create_answ_lan_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sort_answ_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_answ_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sort_answ_lan_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_answ_lan_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sort_answ_quest_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_answ_quest_Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
