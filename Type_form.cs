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
    public partial class Type_form : Form
    {
        databases dat = new databases();

        public Type_form()
        {
            InitializeComponent();
            CmbBx_type.Items.AddRange(dat.get_types().ToArray());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dat.create_type_quest(TxtBx_type_new.Text);
            CmbBx_type.Items.Clear();
            CmbBx_type.Items.AddRange(dat.get_types().ToArray());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int id = dat.get_type_id(CmbBx_type.SelectedItem.ToString());
            dat.update_type_quest(TxtBx_type_old.Text, id);
            CmbBx_type.Items.Clear();
            CmbBx_type.Items.AddRange(dat.get_types().ToArray());
        }

        private void Btn_delete_type_Click(object sender, EventArgs e)
        {
            int id = dat.get_type_id(CmbBx_type.SelectedItem.ToString());
            dat.delete_type_quest(id);
            CmbBx_type.Items.Clear();
            CmbBx_type.Items.AddRange(dat.get_types().ToArray());
        }
    }
}
