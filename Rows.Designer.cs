namespace Gekko
{
    partial class Rows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtFolderName = new Guna.UI.WinForms.GunaTextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtIP = new Guna.UI.WinForms.GunaTextBox();
            this.cbbUserAgent = new Guna.UI.WinForms.GunaComboBox();
            this.btnFolder = new Guna.UI.WinForms.GunaPictureBox();
            this.btnChangeAgent = new Guna.UI.WinForms.GunaPictureBox();
            this.ptbOS = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDeleteProfile = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtFolderName
            // 
            this.txtFolderName.BackColor = System.Drawing.Color.Transparent;
            this.txtFolderName.BaseColor = System.Drawing.SystemColors.WindowText;
            this.txtFolderName.BorderColor = System.Drawing.SystemColors.InfoText;
            this.txtFolderName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFolderName.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtFolderName.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtFolderName.FocusedForeColor = System.Drawing.Color.MediumSpringGreen;
            this.txtFolderName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFolderName.Location = new System.Drawing.Point(375, 28);
            this.txtFolderName.MaxLength = 2147483647;
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.PasswordChar = '\0';
            this.txtFolderName.Radius = 5;
            this.txtFolderName.Size = new System.Drawing.Size(322, 23);
            this.txtFolderName.TabIndex = 144;
            this.txtFolderName.TextOffsetX = 2;
            this.txtFolderName.TextChanged += new System.EventHandler(this.txtFolderName_TextChanged);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(703, 26);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(57, 23);
            this.btnPause.TabIndex = 146;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click_1);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Transparent;
            this.txtIP.BaseColor = System.Drawing.SystemColors.WindowText;
            this.txtIP.BorderColor = System.Drawing.SystemColors.InfoText;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIP.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtIP.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtIP.FocusedForeColor = System.Drawing.Color.MediumSpringGreen;
            this.txtIP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtIP.Location = new System.Drawing.Point(3, 28);
            this.txtIP.MaxLength = 2147483647;
            this.txtIP.Name = "txtIP";
            this.txtIP.PasswordChar = '\0';
            this.txtIP.Radius = 5;
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(351, 23);
            this.txtIP.TabIndex = 156;
            this.txtIP.TextOffsetX = 2;
            // 
            // cbbUserAgent
            // 
            this.cbbUserAgent.BackColor = System.Drawing.Color.Transparent;
            this.cbbUserAgent.BaseColor = System.Drawing.SystemColors.WindowText;
            this.cbbUserAgent.BorderColor = System.Drawing.SystemColors.InfoText;
            this.cbbUserAgent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbUserAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbUserAgent.FocusedColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbUserAgent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserAgent.ForeColor = System.Drawing.SystemColors.Window;
            this.cbbUserAgent.Items.AddRange(new object[] {
            "Custom UserAgent"});
            this.cbbUserAgent.Location = new System.Drawing.Point(3, 4);
            this.cbbUserAgent.Name = "cbbUserAgent";
            this.cbbUserAgent.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbUserAgent.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbUserAgent.Radius = 5;
            this.cbbUserAgent.Size = new System.Drawing.Size(788, 21);
            this.cbbUserAgent.TabIndex = 161;
            this.cbbUserAgent.SelectedIndexChanged += new System.EventHandler(this.cbbUserAgent_SelectedIndexChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.BaseColor = System.Drawing.Color.White;
            this.btnFolder.Image = global::Gekko.Properties.Resources.edit;
            this.btnFolder.Location = new System.Drawing.Point(360, 28);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(20, 22);
            this.btnFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFolder.TabIndex = 170;
            this.btnFolder.TabStop = false;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click_1);
            // 
            // btnChangeAgent
            // 
            this.btnChangeAgent.BaseColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangeAgent.Image = global::Gekko.Properties.Resources.forward_alt;
            this.btnChangeAgent.Location = new System.Drawing.Point(766, 26);
            this.btnChangeAgent.Name = "btnChangeAgent";
            this.btnChangeAgent.Size = new System.Drawing.Size(25, 25);
            this.btnChangeAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChangeAgent.TabIndex = 160;
            this.btnChangeAgent.TabStop = false;
            this.btnChangeAgent.Click += new System.EventHandler(this.BtnChangeAgent_Click);
            // 
            // ptbOS
            // 
            this.ptbOS.BaseColor = System.Drawing.Color.White;
            this.ptbOS.Image = global::Gekko.Properties.Resources.android;
            this.ptbOS.Location = new System.Drawing.Point(797, 4);
            this.ptbOS.Name = "ptbOS";
            this.ptbOS.Size = new System.Drawing.Size(48, 50);
            this.ptbOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbOS.TabIndex = 149;
            this.ptbOS.TabStop = false;
            this.ptbOS.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BaseColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Image = global::Gekko.Properties.Resources.delete;
            this.btnDeleteProfile.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(25, 22);
            this.btnDeleteProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteProfile.TabIndex = 141;
            this.btnDeleteProfile.TabStop = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.BtnDeleteProfile_Click);
            // 
            // Rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.cbbUserAgent);
            this.Controls.Add(this.btnChangeAgent);
            this.Controls.Add(this.ptbOS);
            this.Controls.Add(this.txtFolderName);
            this.Name = "Rows";
            this.Size = new System.Drawing.Size(849, 51);
            this.MouseEnter += new System.EventHandler(this.Rows_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Rows_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.btnFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaComboBox cbbUserAgent;
        private Guna.UI.WinForms.GunaPictureBox btnChangeAgent;
        private Guna.UI.WinForms.GunaTextBox txtIP;
        private Guna.UI.WinForms.GunaPictureBox ptbOS;
        private System.Windows.Forms.Button btnPause;
        private Guna.UI.WinForms.GunaTextBox txtFolderName;
        private Guna.UI.WinForms.GunaPictureBox btnDeleteProfile;
        private Guna.UI.WinForms.GunaPictureBox btnFolder;
    }
}
