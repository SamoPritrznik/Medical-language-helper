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
    public partial class Language_form : Form
    {

        databases dat = new databases();

        public Language_form()
        {
            InitializeComponent();
            Combobx_lang.Items.AddRange(dat.get_languages().ToArray());
        }

        private void Btn_save_new_Click(object sender, EventArgs e)
        {
            dat.save_language(txtbx_mother_new.Text, txtbx_foreign_new.Text);
            Combobx_lang.Items.Clear();
            Combobx_lang.Items.AddRange(dat.get_languages().ToArray());
        }

        private void Btn_save_old_Click(object sender, EventArgs e)
        {

            int id = dat.get_language_id(Combobx_lang.SelectedItem.ToString());
            dat.change_languages(txtbx_foreign_old.Text, txtbx_mother_old.Text, id);
            Combobx_lang.Items.Clear();
            Combobx_lang.Items.AddRange(dat.get_languages().ToArray());
            txtbx_foreign_old.Clear();
            txtbx_mother_old.Clear();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            int id = dat.get_language_id(Combobx_lang.SelectedItem.ToString());
            dat.delete_languages(id);
            Combobx_lang.Items.Clear();
            Combobx_lang.Items.AddRange(dat.get_languages().ToArray());
            txtbx_foreign_old.Clear();
            txtbx_mother_old.Clear();
            
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Combobx_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
