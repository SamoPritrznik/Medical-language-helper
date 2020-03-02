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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void Edit_language_btn_Click(object sender, EventArgs e)
        {
            Language_form lan = new Language_form();
            lan.Show();
        }

        private void Edit_category_btn_Click(object sender, EventArgs e)
        {
            Category_form cat = new Category_form();
            cat.Show();
        }

        private void Edit_type_btn_Click(object sender, EventArgs e)
        {
            Type_form typ = new Type_form();
            typ.Show();
        }

        private void Edit_question_btn_Click(object sender, EventArgs e)
        {
            Question_form que = new Question_form();
            que.Show();
        }
    }
}
