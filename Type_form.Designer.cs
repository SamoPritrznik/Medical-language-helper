namespace medical_project_real
{
    partial class Type_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBx_type_new = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_new_type = new System.Windows.Forms.Button();
            this.CmbBx_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBx_type_old = new System.Windows.Forms.TextBox();
            this.Btn_update_type = new System.Windows.Forms.Button();
            this.Btn_delete_type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBx_type_new
            // 
            this.TxtBx_type_new.Location = new System.Drawing.Point(32, 41);
            this.TxtBx_type_new.Name = "TxtBx_type_new";
            this.TxtBx_type_new.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_type_new.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ustvari tip vprašanja";
            // 
            // Btn_new_type
            // 
            this.Btn_new_type.Location = new System.Drawing.Point(32, 67);
            this.Btn_new_type.Name = "Btn_new_type";
            this.Btn_new_type.Size = new System.Drawing.Size(75, 23);
            this.Btn_new_type.TabIndex = 11;
            this.Btn_new_type.Text = "Ustvari";
            this.Btn_new_type.UseVisualStyleBackColor = true;
            this.Btn_new_type.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CmbBx_type
            // 
            this.CmbBx_type.FormattingEnabled = true;
            this.CmbBx_type.Location = new System.Drawing.Point(236, 41);
            this.CmbBx_type.Name = "CmbBx_type";
            this.CmbBx_type.Size = new System.Drawing.Size(121, 21);
            this.CmbBx_type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Uredi tip vprašanja";
            // 
            // TxtBx_type_old
            // 
            this.TxtBx_type_old.Location = new System.Drawing.Point(236, 68);
            this.TxtBx_type_old.Name = "TxtBx_type_old";
            this.TxtBx_type_old.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_type_old.TabIndex = 17;
            // 
            // Btn_update_type
            // 
            this.Btn_update_type.Location = new System.Drawing.Point(236, 94);
            this.Btn_update_type.Name = "Btn_update_type";
            this.Btn_update_type.Size = new System.Drawing.Size(75, 23);
            this.Btn_update_type.TabIndex = 18;
            this.Btn_update_type.Text = "Uredi";
            this.Btn_update_type.UseVisualStyleBackColor = true;
            this.Btn_update_type.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Btn_delete_type
            // 
            this.Btn_delete_type.Location = new System.Drawing.Point(236, 123);
            this.Btn_delete_type.Name = "Btn_delete_type";
            this.Btn_delete_type.Size = new System.Drawing.Size(75, 23);
            this.Btn_delete_type.TabIndex = 19;
            this.Btn_delete_type.Text = "Izbriši";
            this.Btn_delete_type.UseVisualStyleBackColor = true;
            this.Btn_delete_type.Click += new System.EventHandler(this.Btn_delete_type_Click);
            // 
            // Type_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 177);
            this.Controls.Add(this.Btn_delete_type);
            this.Controls.Add(this.TxtBx_type_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_new_type);
            this.Controls.Add(this.CmbBx_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBx_type_old);
            this.Controls.Add(this.Btn_update_type);
            this.Name = "Type_form";
            this.Text = "Type_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBx_type_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_new_type;
        private System.Windows.Forms.ComboBox CmbBx_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBx_type_old;
        private System.Windows.Forms.Button Btn_update_type;
        private System.Windows.Forms.Button Btn_delete_type;
    }
}