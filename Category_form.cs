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
    public partial class Category_form : Form
    {
        databases dat = new databases();
        public Category_form()
        {
            InitializeComponent();
            ComBx_cat_new.Items.AddRange(dat.get_categories().ToArray());
            ComBx_cat_old.Items.AddRange(dat.get_categories().ToArray());
            ComBx_lan_new.Items.AddRange(dat.get_languages().ToArray());
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
            ComBx_lan_old.Items.AddRange(dat.get_languages().ToArray());

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            dat.new_category(Txtbx_cat_new.Text);
            ComBx_cat_new.Items.Clear();
            ComBx_cat_new.Items.AddRange(dat.get_categories().ToArray());
            ComBx_cat_old.Items.Clear();
            ComBx_cat_old.Items.AddRange(dat.get_categories().ToArray());
            ComboBx_cat1_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            int lan_id = dat.get_language_id(ComBx_lan_new.SelectedItem.ToString());
            int cat_id = dat.get_category_id(ComBx_cat_new.SelectedItem.ToString());
            dat.new_translation_cat_lan(Txtbx_tran_new.Text, lan_id, cat_id);
            ComboBx_cat1_lan_old.Items.Clear();
            ComBx_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
            ComBx_lan_old.Items.AddRange(dat.get_languages().ToArray());
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            int id = dat.get_category_id(ComBx_cat_old.SelectedItem.ToString());
            dat.new_cat(Txtbx_cat_old.Text, id);
            ComBx_cat_new.Items.Clear();
            ComBx_cat_new.Items.AddRange(dat.get_categories().ToArray());
            ComBx_cat_old.Items.Clear();
            ComBx_cat_old.Items.AddRange(dat.get_categories().ToArray());
            ComboBx_cat1_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
        }

        private void Btn_sort_Click(object sender, EventArgs e)
        {
            int id_cat = dat.get_tran_category_id(ComboBx_cat1_lan_old.SelectedItem.ToString());
            int id_lan = dat.get_tran_language_id(ComBx_lan_new.SelectedItem.ToString());
            dat.new_trans(Txtbx_tran_old.Text, id_cat, id_lan);
            ComboBx_cat1_lan_old.Items.Clear();
            ComBx_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
            ComBx_lan_old.Items.AddRange(dat.get_languages().ToArray());
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_del_cat_Click(object sender, EventArgs e)
        {
            int id = dat.get_category_id(ComBx_cat_old.SelectedItem.ToString());
            dat.del_cat(id);
            ComBx_cat_new.Items.Clear();
            ComBx_cat_new.Items.AddRange(dat.get_categories().ToArray());
            ComBx_cat_old.Items.Clear();
            ComBx_cat_old.Items.AddRange(dat.get_categories().ToArray());
            ComboBx_cat1_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
        }

        private void Btn_del_trans_Click(object sender, EventArgs e)
        {
            int id_cat = dat.get_tran_category_id(ComboBx_cat1_lan_old.SelectedItem.ToString());
            int id_lan = dat.get_tran_language_id(ComBx_lan_old.SelectedItem.ToString());
            dat.del_trans(id_cat, id_lan);
            ComboBx_cat1_lan_old.Items.Clear();
            ComboBx_cat1_lan_old.Items.AddRange(dat.get_categories().ToArray());
            ComBx_lan_old.Items.Clear();
            
            ComBx_lan_old.Items.AddRange(dat.get_languages().ToArray());
        }

    }
}
