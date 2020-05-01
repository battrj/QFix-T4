namespace Gekko
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txtLink = new Guna.UI.WinForms.GunaTextBox();
            this.txtYear = new Guna.UI.WinForms.GunaTextBox();
            this.txtMonth = new Guna.UI.WinForms.GunaTextBox();
            this.txtCCNum = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.cbbJS = new Guna.UI.WinForms.GunaComboBox();
            this.txtData = new Guna.UI.WinForms.GunaTextBox();
            this.cbbWebGL = new Guna.UI.WinForms.GunaComboBox();
            this.cbbDevice = new Guna.UI.WinForms.GunaComboBox();
            this.pnlWorking1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.progressbar = new Guna.UI.WinForms.GunaProgressBar();
            this.cbbShipData = new Guna.UI.WinForms.GunaComboBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnFolder = new Guna.UI.WinForms.GunaPictureBox();
            this.btnFolderData = new Guna.UI.WinForms.GunaPictureBox();
            this.btnLoadProfile = new Guna.UI.WinForms.GunaImageButton();
            this.btnDo = new Guna.UI.WinForms.GunaImageButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox6 = new Guna.UI.WinForms.GunaTextBox();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderData)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.Transparent;
            this.txtLink.BaseColor = System.Drawing.Color.Black;
            this.txtLink.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtLink.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtLink.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtLink.Location = new System.Drawing.Point(14, 48);
            this.txtLink.MaxLength = 2147483647;
            this.txtLink.Name = "txtLink";
            this.txtLink.PasswordChar = '\0';
            this.txtLink.Radius = 5;
            this.txtLink.Size = new System.Drawing.Size(234, 28);
            this.txtLink.TabIndex = 92;
            this.txtLink.Text = "Item link";
            this.txtLink.TextOffsetX = 2;
            this.txtLink.TextChanged += new System.EventHandler(this.TxtLink_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.BaseColor = System.Drawing.Color.Black;
            this.txtYear.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtYear.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtYear.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtYear.Location = new System.Drawing.Point(423, 13);
            this.txtYear.MaxLength = 2147483647;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.Radius = 5;
            this.txtYear.Size = new System.Drawing.Size(35, 28);
            this.txtYear.TabIndex = 91;
            this.txtYear.Text = "yy";
            this.txtYear.TextOffsetX = 2;
            this.txtYear.TextChanged += new System.EventHandler(this.TxtYear_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.Transparent;
            this.txtMonth.BaseColor = System.Drawing.Color.Black;
            this.txtMonth.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonth.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtMonth.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtMonth.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMonth.Location = new System.Drawing.Point(382, 13);
            this.txtMonth.MaxLength = 2147483647;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.PasswordChar = '\0';
            this.txtMonth.Radius = 5;
            this.txtMonth.Size = new System.Drawing.Size(35, 28);
            this.txtMonth.TabIndex = 90;
            this.txtMonth.Text = "mm";
            this.txtMonth.TextOffsetX = 2;
            this.txtMonth.TextChanged += new System.EventHandler(this.TxtMonth_TextChanged);
            // 
            // txtCCNum
            // 
            this.txtCCNum.BackColor = System.Drawing.Color.Transparent;
            this.txtCCNum.BaseColor = System.Drawing.Color.Black;
            this.txtCCNum.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCCNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCNum.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtCCNum.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtCCNum.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCCNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCNum.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCCNum.Location = new System.Drawing.Point(254, 13);
            this.txtCCNum.MaxLength = 2147483647;
            this.txtCCNum.Name = "txtCCNum";
            this.txtCCNum.PasswordChar = '\0';
            this.txtCCNum.Radius = 5;
            this.txtCCNum.Size = new System.Drawing.Size(122, 28);
            this.txtCCNum.TabIndex = 89;
            this.txtCCNum.Text = "ccnumber";
            this.txtCCNum.TextOffsetX = 2;
            this.txtCCNum.TextChanged += new System.EventHandler(this.TxtCCNum_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.Black;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtPassword.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPassword.Location = new System.Drawing.Point(157, 13);
            this.txtPassword.MaxLength = 2147483647;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 5;
            this.txtPassword.Size = new System.Drawing.Size(91, 28);
            this.txtPassword.TabIndex = 88;
            this.txtPassword.Text = "pass";
            this.txtPassword.TextOffsetX = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BaseColor = System.Drawing.Color.Black;
            this.txtFullName.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtFullName.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtFullName.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtFullName.Location = new System.Drawing.Point(464, 11);
            this.txtFullName.MaxLength = 2147483647;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Radius = 5;
            this.txtFullName.Size = new System.Drawing.Size(106, 28);
            this.txtFullName.TabIndex = 87;
            this.txtFullName.Text = "Name";
            this.txtFullName.TextOffsetX = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.TxtFullName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.Black;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtEmail.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEmail.Location = new System.Drawing.Point(14, 12);
            this.txtEmail.MaxLength = 2147483647;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 5;
            this.txtEmail.Size = new System.Drawing.Size(137, 28);
            this.txtEmail.TabIndex = 84;
            this.txtEmail.Text = "email";
            this.txtEmail.TextOffsetX = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // cbbJS
            // 
            this.cbbJS.BackColor = System.Drawing.Color.Transparent;
            this.cbbJS.BaseColor = System.Drawing.Color.Black;
            this.cbbJS.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbJS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbJS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbJS.FocusedColor = System.Drawing.Color.Empty;
            this.cbbJS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbJS.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbJS.FormattingEnabled = true;
            this.cbbJS.Items.AddRange(new object[] {
            "Normal",
            "Business"});
            this.cbbJS.Location = new System.Drawing.Point(719, 12);
            this.cbbJS.Name = "cbbJS";
            this.cbbJS.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbJS.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbJS.Radius = 5;
            this.cbbJS.Size = new System.Drawing.Size(98, 26);
            this.cbbJS.TabIndex = 82;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.BackColor = System.Drawing.Color.Transparent;
            this.txtData.BaseColor = System.Drawing.SystemColors.WindowText;
            this.txtData.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtData.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.txtData.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtData.Location = new System.Drawing.Point(14, 81);
            this.txtData.MaxLength = 2147483647;
            this.txtData.MultiLine = true;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.Radius = 5;
            this.txtData.Size = new System.Drawing.Size(616, 45);
            this.txtData.TabIndex = 79;
            this.txtData.TextOffsetX = 2;
            this.txtData.TextChanged += new System.EventHandler(this.TxtData_TextChanged);
            // 
            // cbbWebGL
            // 
            this.cbbWebGL.BackColor = System.Drawing.Color.Transparent;
            this.cbbWebGL.BaseColor = System.Drawing.Color.Black;
            this.cbbWebGL.BorderColor = System.Drawing.Color.DeepPink;
            this.cbbWebGL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWebGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWebGL.FocusedColor = System.Drawing.Color.Empty;
            this.cbbWebGL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbWebGL.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbWebGL.FormattingEnabled = true;
            this.cbbWebGL.Location = new System.Drawing.Point(14, 136);
            this.cbbWebGL.Name = "cbbWebGL";
            this.cbbWebGL.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbWebGL.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbWebGL.Radius = 5;
            this.cbbWebGL.Size = new System.Drawing.Size(897, 26);
            this.cbbWebGL.TabIndex = 78;
            this.cbbWebGL.SelectedIndexChanged += new System.EventHandler(this.CbbWebGL_SelectedIndexChanged);
            // 
            // cbbDevice
            // 
            this.cbbDevice.BackColor = System.Drawing.Color.Transparent;
            this.cbbDevice.BaseColor = System.Drawing.Color.Black;
            this.cbbDevice.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDevice.FocusedColor = System.Drawing.Color.Empty;
            this.cbbDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDevice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbDevice.FormattingEnabled = true;
            this.cbbDevice.Items.AddRange(new object[] {
            "Windows",
            "iPad",
            "Android",
            "iPhone",
            "Macintosh"});
            this.cbbDevice.Location = new System.Drawing.Point(819, 11);
            this.cbbDevice.Name = "cbbDevice";
            this.cbbDevice.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbDevice.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbDevice.Radius = 5;
            this.cbbDevice.Size = new System.Drawing.Size(98, 26);
            this.cbbDevice.TabIndex = 76;
            this.cbbDevice.SelectedIndexChanged += new System.EventHandler(this.cbbDevice_SelectedIndexChanged);
            // 
            // pnlWorking1
            // 
            this.pnlWorking1.AutoScroll = true;
            this.pnlWorking1.BackColor = System.Drawing.Color.Transparent;
            this.pnlWorking1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlWorking1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlWorking1.Location = new System.Drawing.Point(15, 168);
            this.pnlWorking1.Name = "pnlWorking1";
            this.pnlWorking1.Size = new System.Drawing.Size(902, 188);
            this.pnlWorking1.TabIndex = 74;
            this.pnlWorking1.WrapContents = false;
            this.pnlWorking1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWorking1_Paint);
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.progressbar);
            this.pnlLoading.Location = new System.Drawing.Point(922, 52);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(125, 32);
            this.pnlLoading.TabIndex = 7;
            this.pnlLoading.Visible = false;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.BorderColor = System.Drawing.Color.Black;
            this.progressbar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressbar.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.progressbar.Location = new System.Drawing.Point(0, 0);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressMaxColor = System.Drawing.Color.LawnGreen;
            this.progressbar.ProgressMinColor = System.Drawing.Color.Green;
            this.progressbar.Radius = 5;
            this.progressbar.Size = new System.Drawing.Size(105, 32);
            this.progressbar.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            this.progressbar.TabIndex = 6;
            // 
            // cbbShipData
            // 
            this.cbbShipData.BackColor = System.Drawing.Color.Transparent;
            this.cbbShipData.BaseColor = System.Drawing.Color.Black;
            this.cbbShipData.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbShipData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbShipData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShipData.FocusedColor = System.Drawing.Color.Empty;
            this.cbbShipData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbShipData.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbShipData.FormattingEnabled = true;
            this.cbbShipData.Location = new System.Drawing.Point(701, 47);
            this.cbbShipData.Name = "cbbShipData";
            this.cbbShipData.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbShipData.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbShipData.Radius = 5;
            this.cbbShipData.Size = new System.Drawing.Size(210, 26);
            this.cbbShipData.TabIndex = 103;
            this.cbbShipData.SelectedIndexChanged += new System.EventHandler(this.CbbShipData_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderSize = 2;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.Transparent;
            this.btnReset.Image = global::Gekko.Properties.Resources.refresh;
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(34, 34);
            this.btnReset.Location = new System.Drawing.Point(983, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnReset.Radius = 5;
            this.btnReset.Size = new System.Drawing.Size(37, 25);
            this.btnReset.TabIndex = 8;
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BaseColor = System.Drawing.Color.White;
            this.btnFolder.Image = global::Gekko.Properties.Resources.folder;
            this.btnFolder.Location = new System.Drawing.Point(953, 12);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(24, 25);
            this.btnFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFolder.TabIndex = 169;
            this.btnFolder.TabStop = false;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnFolderData
            // 
            this.btnFolderData.BaseColor = System.Drawing.Color.White;
            this.btnFolderData.Image = global::Gekko.Properties.Resources.document;
            this.btnFolderData.Location = new System.Drawing.Point(923, 12);
            this.btnFolderData.Name = "btnFolderData";
            this.btnFolderData.Size = new System.Drawing.Size(24, 25);
            this.btnFolderData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFolderData.TabIndex = 163;
            this.btnFolderData.TabStop = false;
            this.btnFolderData.Click += new System.EventHandler(this.BtnFolderData_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadProfile.Image = global::Gekko.Properties.Resources.reload;
            this.btnLoadProfile.ImageSize = new System.Drawing.Size(60, 60);
            this.btnLoadProfile.Location = new System.Drawing.Point(987, 99);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.OnHoverImage = null;
            this.btnLoadProfile.OnHoverImageOffset = new System.Drawing.Point(1, 1);
            this.btnLoadProfile.Size = new System.Drawing.Size(60, 60);
            this.btnLoadProfile.TabIndex = 170;
            this.btnLoadProfile.Click += new System.EventHandler(this.BtnLoadProfile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.Transparent;
            this.btnDo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDo.Image = global::Gekko.Properties.Resources.plus1;
            this.btnDo.ImageSize = new System.Drawing.Size(60, 60);
            this.btnDo.Location = new System.Drawing.Point(917, 102);
            this.btnDo.Name = "btnDo";
            this.btnDo.OnHoverImage = null;
            this.btnDo.OnHoverImageOffset = new System.Drawing.Point(1, 1);
            this.btnDo.Size = new System.Drawing.Size(60, 60);
            this.btnDo.TabIndex = 75;
            this.btnDo.Click += new System.EventHandler(this.GunaImageButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderSize = 2;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::Gekko.Properties.Resources.delete1;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.Location = new System.Drawing.Point(1020, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Radius = 5;
            this.btnExit.Size = new System.Drawing.Size(37, 25);
            this.btnExit.TabIndex = 171;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox1.Location = new System.Drawing.Point(254, 47);
            this.gunaTextBox1.MaxLength = 2147483647;
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 5;
            this.gunaTextBox1.Size = new System.Drawing.Size(122, 28);
            this.gunaTextBox1.TabIndex = 172;
            this.gunaTextBox1.Text = "add";
            this.gunaTextBox1.TextOffsetX = 2;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox2.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox2.Location = new System.Drawing.Point(382, 49);
            this.gunaTextBox2.MaxLength = 2147483647;
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 5;
            this.gunaTextBox2.Size = new System.Drawing.Size(76, 28);
            this.gunaTextBox2.TabIndex = 173;
            this.gunaTextBox2.Text = "city";
            this.gunaTextBox2.TextOffsetX = 2;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox3.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox3.Location = new System.Drawing.Point(464, 47);
            this.gunaTextBox3.MaxLength = 2147483647;
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.Radius = 5;
            this.gunaTextBox3.Size = new System.Drawing.Size(51, 28);
            this.gunaTextBox3.TabIndex = 174;
            this.gunaTextBox3.Text = "state";
            this.gunaTextBox3.TextOffsetX = 2;
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox4.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox4.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox4.Location = new System.Drawing.Point(521, 47);
            this.gunaTextBox4.MaxLength = 2147483647;
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.Radius = 5;
            this.gunaTextBox4.Size = new System.Drawing.Size(65, 28);
            this.gunaTextBox4.TabIndex = 174;
            this.gunaTextBox4.Text = "zipcode";
            this.gunaTextBox4.TextOffsetX = 2;
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox5.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox5.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox5.Location = new System.Drawing.Point(592, 47);
            this.gunaTextBox5.MaxLength = 2147483647;
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.Radius = 5;
            this.gunaTextBox5.Size = new System.Drawing.Size(98, 28);
            this.gunaTextBox5.TabIndex = 175;
            this.gunaTextBox5.Text = "phone";
            this.gunaTextBox5.TextOffsetX = 2;
            // 
            // gunaTextBox6
            // 
            this.gunaTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox6.BaseColor = System.Drawing.Color.Black;
            this.gunaTextBox6.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox6.FocusedBaseColor = System.Drawing.Color.Black;
            this.gunaTextBox6.FocusedBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaTextBox6.FocusedForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaTextBox6.Location = new System.Drawing.Point(582, 10);
            this.gunaTextBox6.MaxLength = 2147483647;
            this.gunaTextBox6.Name = "gunaTextBox6";
            this.gunaTextBox6.PasswordChar = '\0';
            this.gunaTextBox6.Radius = 5;
            this.gunaTextBox6.Size = new System.Drawing.Size(131, 28);
            this.gunaTextBox6.TabIndex = 176;
            this.gunaTextBox6.Text = "EIN";
            this.gunaTextBox6.TextOffsetX = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::Gekko.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1057, 368);
            this.Controls.Add(this.gunaTextBox6);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbJS);
            this.Controls.Add(this.cbbDevice);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnFolderData);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbbShipData);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtCCNum);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cbbWebGL);
            this.Controls.Add(this.pnlWorking1);
            this.Controls.Add(this.gunaTextBox5);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaTextBox3);
            this.Controls.Add(this.gunaTextBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NZT-XekoGL";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaTextBox txtLink;
        private Guna.UI.WinForms.GunaTextBox txtYear;
        private Guna.UI.WinForms.GunaTextBox txtMonth;
        private Guna.UI.WinForms.GunaTextBox txtCCNum;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaComboBox cbbJS;
        private Guna.UI.WinForms.GunaTextBox txtData;
        private Guna.UI.WinForms.GunaComboBox cbbWebGL;
        private Guna.UI.WinForms.GunaComboBox cbbDevice;
        private Guna.UI.WinForms.GunaImageButton btnDo;
        private System.Windows.Forms.FlowLayoutPanel pnlWorking1;
        private System.Windows.Forms.Panel pnlLoading;
        private Guna.UI.WinForms.GunaComboBox cbbShipData;
        private Guna.UI.WinForms.GunaPictureBox btnFolderData;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaPictureBox btnFolder;
        private Guna.UI.WinForms.GunaImageButton btnLoadProfile;
        private Guna.UI.WinForms.GunaProgressBar progressbar;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox6;
    }
}

