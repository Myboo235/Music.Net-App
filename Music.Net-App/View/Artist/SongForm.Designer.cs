namespace Music.Net_App.View.Artist
{
    partial class SongForm
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Delete_Song = new System.Windows.Forms.Panel();
            this.Button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_OK = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Choose_File = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_Modify_Song = new FontAwesome.Sharp.IconButton();
            this.Button_Add_Song = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3.SuspendLayout();
            this.Button_Delete_Song.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.flowLayoutPanel3.Controls.Add(this.Button_Delete_Song);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1215, 628);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // Button_Delete_Song
            // 
            this.Button_Delete_Song.Controls.Add(this.Button_Delete);
            this.Button_Delete_Song.Controls.Add(this.guna2ComboBox1);
            this.Button_Delete_Song.Controls.Add(this.label5);
            this.Button_Delete_Song.Controls.Add(this.Button_OK);
            this.Button_Delete_Song.Controls.Add(this.Button_Cancel);
            this.Button_Delete_Song.Controls.Add(this.Button_Choose_File);
            this.Button_Delete_Song.Controls.Add(this.label2);
            this.Button_Delete_Song.Controls.Add(this.label3);
            this.Button_Delete_Song.Controls.Add(this.label4);
            this.Button_Delete_Song.Controls.Add(this.label1);
            this.Button_Delete_Song.Controls.Add(this.guna2TextBox2);
            this.Button_Delete_Song.Controls.Add(this.guna2TextBox1);
            this.Button_Delete_Song.Controls.Add(this.Button_Modify_Song);
            this.Button_Delete_Song.Controls.Add(this.Button_Add_Song);
            this.Button_Delete_Song.Location = new System.Drawing.Point(3, 3);
            this.Button_Delete_Song.Name = "Button_Delete_Song";
            this.Button_Delete_Song.Size = new System.Drawing.Size(1200, 108);
            this.Button_Delete_Song.TabIndex = 3;
            // 
            // Button_Delete
            // 
            this.Button_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Delete.ForeColor = System.Drawing.Color.White;
            this.Button_Delete.Location = new System.Drawing.Point(537, 498);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(180, 45);
            this.Button_Delete.TabIndex = 8;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.Visible = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(312, 186);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(229, 36);
            this.guna2ComboBox1.TabIndex = 7;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your File";
            // 
            // Button_OK
            // 
            this.Button_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_OK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_OK.ForeColor = System.Drawing.Color.White;
            this.Button_OK.Location = new System.Drawing.Point(948, 498);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(180, 45);
            this.Button_OK.TabIndex = 5;
            this.Button_OK.Text = "OK";
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Cancel.FillColor = System.Drawing.Color.White;
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Button_Cancel.Location = new System.Drawing.Point(746, 498);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(180, 45);
            this.Button_Cancel.TabIndex = 5;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Choose_File
            // 
            this.Button_Choose_File.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_Choose_File.IconColor = System.Drawing.Color.Black;
            this.Button_Choose_File.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Choose_File.Location = new System.Drawing.Point(312, 287);
            this.Button_Choose_File.Name = "Button_Choose_File";
            this.Button_Choose_File.Size = new System.Drawing.Size(229, 60);
            this.Button_Choose_File.TabIndex = 4;
            this.Button_Choose_File.Text = "Choose File";
            this.Button_Choose_File.UseVisualStyleBackColor = true;
            this.Button_Choose_File.Click += new System.EventHandler(this.Button_Choose_File_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Song";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Song file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(688, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Song Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(688, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Song Name";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(692, 287);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox2.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(692, 186);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // Button_Modify_Song
            // 
            this.Button_Modify_Song.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Modify_Song.BackColor = System.Drawing.Color.Transparent;
            this.Button_Modify_Song.FlatAppearance.BorderSize = 0;
            this.Button_Modify_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modify_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Modify_Song.ForeColor = System.Drawing.Color.White;
            this.Button_Modify_Song.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            this.Button_Modify_Song.IconColor = System.Drawing.Color.White;
            this.Button_Modify_Song.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Modify_Song.Location = new System.Drawing.Point(931, 27);
            this.Button_Modify_Song.Name = "Button_Modify_Song";
            this.Button_Modify_Song.Size = new System.Drawing.Size(249, 47);
            this.Button_Modify_Song.TabIndex = 0;
            this.Button_Modify_Song.Text = "Modify song";
            this.Button_Modify_Song.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Modify_Song.UseVisualStyleBackColor = false;
            this.Button_Modify_Song.Click += new System.EventHandler(this.Button_Modify_Song_Click);
            // 
            // Button_Add_Song
            // 
            this.Button_Add_Song.BackColor = System.Drawing.Color.Transparent;
            this.Button_Add_Song.FlatAppearance.BorderSize = 0;
            this.Button_Add_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Song.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add_Song.ForeColor = System.Drawing.Color.White;
            this.Button_Add_Song.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Button_Add_Song.IconColor = System.Drawing.Color.White;
            this.Button_Add_Song.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Add_Song.Location = new System.Drawing.Point(12, 27);
            this.Button_Add_Song.Name = "Button_Add_Song";
            this.Button_Add_Song.Size = new System.Drawing.Size(249, 47);
            this.Button_Add_Song.TabIndex = 0;
            this.Button_Add_Song.Text = "Add new song";
            this.Button_Add_Song.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Add_Song.UseVisualStyleBackColor = false;
            this.Button_Add_Song.Click += new System.EventHandler(this.Button_Add_Song_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 488);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1215, 628);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "SongForm";
            this.Text = "SongForm";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.Button_Delete_Song.ResumeLayout(false);
            this.Button_Delete_Song.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel Button_Delete_Song;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private FontAwesome.Sharp.IconButton Button_Add_Song;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton Button_Choose_File;
        private Guna.UI2.WinForms.Guna2Button Button_Cancel;
        private Guna.UI2.WinForms.Guna2Button Button_OK;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton Button_Modify_Song;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Button_Delete;
    }
}