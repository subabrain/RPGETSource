namespace RPGETv6Beta
{
    public partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_place = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.check_admin = new System.Windows.Forms.CheckBox();
            this.textBox_icon = new System.Windows.Forms.TextBox();
            this.button_choose_gtk_file = new System.Windows.Forms.Button();
            this.button_choose_gtk_folder = new System.Windows.Forms.Button();
            this.button_choose_icon = new System.Windows.Forms.Button();
            this.button_choose_app_folder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.check_console = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "RPGET v6 - \r\nThe PHP-GTK Encryption Tool!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. What PHP-GTK File you want to Encrypt?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. Where is your PHP-GTK Folder?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "4. Do you want to set an Icon?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "6. Where to Put your ready App?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "3. Whats the Name of your App?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "5. Do you want to require Adminrights?";
            // 
            // textBox_file
            // 
            this.textBox_file.Location = new System.Drawing.Point(13, 133);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(255, 20);
            this.textBox_file.TabIndex = 8;
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(13, 180);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(255, 20);
            this.textBox_folder.TabIndex = 9;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(13, 232);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(255, 20);
            this.textBox_name.TabIndex = 10;
            // 
            // textBox_place
            // 
            this.textBox_place.Location = new System.Drawing.Point(13, 388);
            this.textBox_place.Name = "textBox_place";
            this.textBox_place.Size = new System.Drawing.Size(255, 20);
            this.textBox_place.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPGETv6Beta.Properties.Resources.logo_rpget_klein;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(13, 467);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(255, 39);
            this.encrypt.TabIndex = 14;
            this.encrypt.Text = "Encrypt your PHP-GTK App!";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // check_admin
            // 
            this.check_admin.AutoSize = true;
            this.check_admin.Location = new System.Drawing.Point(13, 335);
            this.check_admin.Name = "check_admin";
            this.check_admin.Size = new System.Drawing.Size(42, 17);
            this.check_admin.TabIndex = 16;
            this.check_admin.Text = "yes";
            this.check_admin.UseVisualStyleBackColor = true;
            // 
            // textBox_icon
            // 
            this.textBox_icon.Location = new System.Drawing.Point(13, 283);
            this.textBox_icon.Name = "textBox_icon";
            this.textBox_icon.Size = new System.Drawing.Size(255, 20);
            this.textBox_icon.TabIndex = 17;
            // 
            // button_choose_gtk_file
            // 
            this.button_choose_gtk_file.Location = new System.Drawing.Point(275, 133);
            this.button_choose_gtk_file.Name = "button_choose_gtk_file";
            this.button_choose_gtk_file.Size = new System.Drawing.Size(181, 23);
            this.button_choose_gtk_file.TabIndex = 18;
            this.button_choose_gtk_file.Text = "Choose File";
            this.button_choose_gtk_file.UseVisualStyleBackColor = true;
            this.button_choose_gtk_file.Click += new System.EventHandler(this.Button_choose_gtk_file_Click);
            // 
            // button_choose_gtk_folder
            // 
            this.button_choose_gtk_folder.Location = new System.Drawing.Point(275, 180);
            this.button_choose_gtk_folder.Name = "button_choose_gtk_folder";
            this.button_choose_gtk_folder.Size = new System.Drawing.Size(181, 23);
            this.button_choose_gtk_folder.TabIndex = 19;
            this.button_choose_gtk_folder.Text = "Choose Folder";
            this.button_choose_gtk_folder.UseVisualStyleBackColor = true;
            this.button_choose_gtk_folder.Click += new System.EventHandler(this.Button_choose_gtk_folder_Click);
            // 
            // button_choose_icon
            // 
            this.button_choose_icon.Location = new System.Drawing.Point(275, 280);
            this.button_choose_icon.Name = "button_choose_icon";
            this.button_choose_icon.Size = new System.Drawing.Size(181, 23);
            this.button_choose_icon.TabIndex = 20;
            this.button_choose_icon.Text = "Choose Icon";
            this.button_choose_icon.UseVisualStyleBackColor = true;
            this.button_choose_icon.Click += new System.EventHandler(this.Button_choose_icon_Click);
            // 
            // button_choose_app_folder
            // 
            this.button_choose_app_folder.Location = new System.Drawing.Point(275, 385);
            this.button_choose_app_folder.Name = "button_choose_app_folder";
            this.button_choose_app_folder.Size = new System.Drawing.Size(181, 23);
            this.button_choose_app_folder.TabIndex = 21;
            this.button_choose_app_folder.Text = "Choose Folder";
            this.button_choose_app_folder.UseVisualStyleBackColor = true;
            this.button_choose_app_folder.Click += new System.EventHandler(this.Button_choose_app_folder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "by Robert Beran - 2019 \r\nrobert@beran-solutions.de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "7. Start without Console Window";
            // 
            // check_console
            // 
            this.check_console.AutoSize = true;
            this.check_console.Location = new System.Drawing.Point(13, 437);
            this.check_console.Name = "check_console";
            this.check_console.Size = new System.Drawing.Size(42, 17);
            this.check_console.TabIndex = 26;
            this.check_console.Text = "yes";
            this.check_console.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Get Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_console);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_choose_app_folder);
            this.Controls.Add(this.button_choose_icon);
            this.Controls.Add(this.button_choose_gtk_folder);
            this.Controls.Add(this.button_choose_gtk_file);
            this.Controls.Add(this.textBox_icon);
            this.Controls.Add(this.check_admin);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.textBox_place);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.textBox_file);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RPGET v6 Beta - by Robert Beran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_file;
        public System.Windows.Forms.TextBox textBox_folder;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_place;
        public System.Windows.Forms.Button encrypt;
        public System.Windows.Forms.CheckBox check_admin;
        public System.Windows.Forms.TextBox textBox_icon;
        public System.Windows.Forms.Button button_choose_gtk_file;
        public System.Windows.Forms.Button button_choose_gtk_folder;
        public System.Windows.Forms.Button button_choose_icon;
        public System.Windows.Forms.Button button_choose_app_folder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox check_console;
        private System.Windows.Forms.Button button1;
    }
}

