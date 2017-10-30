namespace ProjektPodcast2
{
    partial class Settings
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
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnDeletePod = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.comboBoxDeleteCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxDeletePod = new System.Windows.Forms.TextBox();
            this.comboBoxChangeCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxNewCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPodName = new System.Windows.Forms.TextBox();
            this.txtPodNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPodNewCategory = new System.Windows.Forms.TextBox();
            this.txtPodNewUrl = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(202, 28);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Ta bort";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeletePod
            // 
            this.btnDeletePod.Location = new System.Drawing.Point(202, 67);
            this.btnDeletePod.Name = "btnDeletePod";
            this.btnDeletePod.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePod.TabIndex = 1;
            this.btnDeletePod.Text = "Ta bort";
            this.btnDeletePod.UseVisualStyleBackColor = true;
            this.btnDeletePod.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(156, 268);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(121, 27);
            this.btnChangeCategory.TabIndex = 2;
            this.btnChangeCategory.Text = "Ändra";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // comboBoxDeleteCategory
            // 
            this.comboBoxDeleteCategory.FormattingEnabled = true;
            this.comboBoxDeleteCategory.Location = new System.Drawing.Point(12, 28);
            this.comboBoxDeleteCategory.Name = "comboBoxDeleteCategory";
            this.comboBoxDeleteCategory.Size = new System.Drawing.Size(184, 24);
            this.comboBoxDeleteCategory.TabIndex = 3;
            // 
            // txtBoxDeletePod
            // 
            this.txtBoxDeletePod.Location = new System.Drawing.Point(12, 68);
            this.txtBoxDeletePod.Name = "txtBoxDeletePod";
            this.txtBoxDeletePod.Size = new System.Drawing.Size(184, 22);
            this.txtBoxDeletePod.TabIndex = 4;
            this.txtBoxDeletePod.Text = "Namn på podcast";
            // 
            // comboBoxChangeCategory
            // 
            this.comboBoxChangeCategory.FormattingEnabled = true;
            this.comboBoxChangeCategory.Location = new System.Drawing.Point(156, 210);
            this.comboBoxChangeCategory.Name = "comboBoxChangeCategory";
            this.comboBoxChangeCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChangeCategory.TabIndex = 5;
            // 
            // txtBoxNewCategoryName
            // 
            this.txtBoxNewCategoryName.Location = new System.Drawing.Point(156, 240);
            this.txtBoxNewCategoryName.Name = "txtBoxNewCategoryName";
            this.txtBoxNewCategoryName.Size = new System.Drawing.Size(121, 22);
            this.txtBoxNewCategoryName.TabIndex = 6;
            this.txtBoxNewCategoryName.Text = "Nytt namn...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ändra kategori";
            // 
            // txtPodName
            // 
            this.txtPodName.Location = new System.Drawing.Point(12, 153);
            this.txtPodName.Name = "txtPodName";
            this.txtPodName.Size = new System.Drawing.Size(121, 22);
            this.txtPodName.TabIndex = 8;
            this.txtPodName.Text = "Namn på podcast";
            // 
            // txtPodNewName
            // 
            this.txtPodNewName.Location = new System.Drawing.Point(12, 182);
            this.txtPodNewName.Name = "txtPodNewName";
            this.txtPodNewName.Size = new System.Drawing.Size(121, 22);
            this.txtPodNewName.TabIndex = 9;
            this.txtPodNewName.Text = "Nytt namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ändra podcast";
            // 
            // txtPodNewCategory
            // 
            this.txtPodNewCategory.Location = new System.Drawing.Point(12, 211);
            this.txtPodNewCategory.Name = "txtPodNewCategory";
            this.txtPodNewCategory.Size = new System.Drawing.Size(121, 22);
            this.txtPodNewCategory.TabIndex = 11;
            this.txtPodNewCategory.Text = "Ny kategori";
            // 
            // txtPodNewUrl
            // 
            this.txtPodNewUrl.Location = new System.Drawing.Point(12, 240);
            this.txtPodNewUrl.Name = "txtPodNewUrl";
            this.txtPodNewUrl.Size = new System.Drawing.Size(121, 22);
            this.txtPodNewUrl.TabIndex = 12;
            this.txtPodNewUrl.Text = "Ny URL";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 26);
            this.button4.TabIndex = 13;
            this.button4.Text = "Ändra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ta bort kategori eller podcast";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPodNewUrl);
            this.Controls.Add(this.txtPodNewCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPodNewName);
            this.Controls.Add(this.txtPodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNewCategoryName);
            this.Controls.Add(this.comboBoxChangeCategory);
            this.Controls.Add(this.txtBoxDeletePod);
            this.Controls.Add(this.comboBoxDeleteCategory);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnDeletePod);
            this.Controls.Add(this.btnDeleteCategory);
            this.Name = "Settings";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnDeletePod;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.ComboBox comboBoxDeleteCategory;
        private System.Windows.Forms.TextBox txtBoxDeletePod;
        private System.Windows.Forms.ComboBox comboBoxChangeCategory;
        private System.Windows.Forms.TextBox txtBoxNewCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPodName;
        private System.Windows.Forms.TextBox txtPodNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPodNewCategory;
        private System.Windows.Forms.TextBox txtPodNewUrl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}