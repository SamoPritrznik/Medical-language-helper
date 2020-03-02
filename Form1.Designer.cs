namespace medical_project_real
{
    partial class Menu_form
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
            this.Edit_language_btn = new System.Windows.Forms.Button();
            this.Edit_category_btn = new System.Windows.Forms.Button();
            this.Edit_type_btn = new System.Windows.Forms.Button();
            this.Edit_question_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_language_btn
            // 
            this.Edit_language_btn.Location = new System.Drawing.Point(44, 62);
            this.Edit_language_btn.Name = "Edit_language_btn";
            this.Edit_language_btn.Size = new System.Drawing.Size(172, 65);
            this.Edit_language_btn.TabIndex = 0;
            this.Edit_language_btn.Text = "Dodaj/Uredi jezik";
            this.Edit_language_btn.UseVisualStyleBackColor = true;
            this.Edit_language_btn.Click += new System.EventHandler(this.Edit_language_btn_Click);
            // 
            // Edit_category_btn
            // 
            this.Edit_category_btn.Location = new System.Drawing.Point(261, 62);
            this.Edit_category_btn.Name = "Edit_category_btn";
            this.Edit_category_btn.Size = new System.Drawing.Size(172, 65);
            this.Edit_category_btn.TabIndex = 1;
            this.Edit_category_btn.Text = "Dodaj/Uredi kategorijo";
            this.Edit_category_btn.UseVisualStyleBackColor = true;
            this.Edit_category_btn.Click += new System.EventHandler(this.Edit_category_btn_Click);
            // 
            // Edit_type_btn
            // 
            this.Edit_type_btn.Location = new System.Drawing.Point(44, 201);
            this.Edit_type_btn.Name = "Edit_type_btn";
            this.Edit_type_btn.Size = new System.Drawing.Size(172, 65);
            this.Edit_type_btn.TabIndex = 2;
            this.Edit_type_btn.Text = "Dodaj/Uredi tip";
            this.Edit_type_btn.UseVisualStyleBackColor = true;
            this.Edit_type_btn.Click += new System.EventHandler(this.Edit_type_btn_Click);
            // 
            // Edit_question_btn
            // 
            this.Edit_question_btn.Location = new System.Drawing.Point(261, 201);
            this.Edit_question_btn.Name = "Edit_question_btn";
            this.Edit_question_btn.Size = new System.Drawing.Size(172, 65);
            this.Edit_question_btn.TabIndex = 3;
            this.Edit_question_btn.Text = "Dodaj/Uredi vprašanje";
            this.Edit_question_btn.UseVisualStyleBackColor = true;
            this.Edit_question_btn.Click += new System.EventHandler(this.Edit_question_btn_Click);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(486, 324);
            this.Controls.Add(this.Edit_question_btn);
            this.Controls.Add(this.Edit_type_btn);
            this.Controls.Add(this.Edit_category_btn);
            this.Controls.Add(this.Edit_language_btn);
            this.Name = "Menu_form";
            this.Text = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_language_btn;
        private System.Windows.Forms.Button Edit_category_btn;
        private System.Windows.Forms.Button Edit_type_btn;
        private System.Windows.Forms.Button Edit_question_btn;
    }
}

