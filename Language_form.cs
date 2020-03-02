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
        string id_languages;

        public Language_form()
        {
            InitializeComponent();
            
        }

        private void Btn_save_new_Click(object sender, EventArgs e)
        {
            dat.open();
            dat.save_language(txtbx_mother_new.Text, txtbx_foreign_new.Text);
            dat.close();
        }

        private void Btn_save_old_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

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
