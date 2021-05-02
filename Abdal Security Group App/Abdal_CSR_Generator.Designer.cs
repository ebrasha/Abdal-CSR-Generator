namespace Abdal_Security_Group_App
{
    partial class Abdal_AES_Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abdal_AES_Encryption));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.keySizeToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.CountryTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.EncDecButton = new Telerik.WinControls.UI.RadButton();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.StateTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.OrganizationTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.LocalityTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.OrganizationalUnitTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.CommonNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.PrivateKeyPasswordTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.EmailAddressTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement4 = new Telerik.WinControls.UI.RadLabelElement();
            this.backgroundWorkerCsr = new System.ComponentModel.BackgroundWorker();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySizeToggleSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationalUnitTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrivateKeyPasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailAddressTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(11, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(46, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Country";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // keySizeToggleSwitch
            // 
            this.keySizeToggleSwitch.Location = new System.Drawing.Point(12, 255);
            this.keySizeToggleSwitch.Name = "keySizeToggleSwitch";
            this.keySizeToggleSwitch.OffText = "4096";
            this.keySizeToggleSwitch.OnText = "2048";
            this.keySizeToggleSwitch.Size = new System.Drawing.Size(237, 20);
            this.keySizeToggleSwitch.TabIndex = 5;
            this.keySizeToggleSwitch.ThemeName = "VisualStudio2012Dark";
            this.keySizeToggleSwitch.ThumbTickness = 15;
            this.keySizeToggleSwitch.ValueChanged += new System.EventHandler(this.EncryptToggleSwitch_ValueChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(11, 36);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.NullText = "IR";
            this.CountryTextBox.Size = new System.Drawing.Size(237, 24);
            this.CountryTextBox.TabIndex = 1;
            this.CountryTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // EncDecButton
            // 
            this.EncDecButton.Location = new System.Drawing.Point(266, 251);
            this.EncDecButton.Name = "EncDecButton";
            this.EncDecButton.Size = new System.Drawing.Size(236, 24);
            this.EncDecButton.TabIndex = 10;
            this.EncDecButton.Text = "Generate CSR";
            this.EncDecButton.ThemeName = "VisualStudio2012Dark";
            this.EncDecButton.Click += new System.EventHandler(this.EncDecButton_Click);
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.AutoCloseDelay = 8;
            this.radDesktopAlert1.PopupAnimationEasing = Telerik.WinControls.RadEasingType.InQuart;
            this.radDesktopAlert1.ShowOptionsButton = false;
            this.radDesktopAlert1.ThemeName = "VisualStudio2012Dark";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(11, 90);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.NullText = "Hormozgan";
            this.StateTextBox.Size = new System.Drawing.Size(237, 24);
            this.StateTextBox.TabIndex = 2;
            this.StateTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(11, 66);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(32, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "State";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // OrganizationTextBox
            // 
            this.OrganizationTextBox.Location = new System.Drawing.Point(11, 198);
            this.OrganizationTextBox.Name = "OrganizationTextBox";
            this.OrganizationTextBox.NullText = "Nahaanbin CyberSecurity Company";
            this.OrganizationTextBox.Size = new System.Drawing.Size(237, 24);
            this.OrganizationTextBox.TabIndex = 4;
            this.OrganizationTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(11, 174);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 18);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Organization";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // LocalityTextBox
            // 
            this.LocalityTextBox.Location = new System.Drawing.Point(11, 144);
            this.LocalityTextBox.Name = "LocalityTextBox";
            this.LocalityTextBox.NullText = "Kish Island";
            this.LocalityTextBox.Size = new System.Drawing.Size(237, 24);
            this.LocalityTextBox.TabIndex = 3;
            this.LocalityTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(11, 120);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(44, 18);
            this.radLabel8.TabIndex = 11;
            this.radLabel8.Text = "Locality";
            this.radLabel8.ThemeName = "VisualStudio2012Dark";
            // 
            // OrganizationalUnitTextBox
            // 
            this.OrganizationalUnitTextBox.Location = new System.Drawing.Point(266, 36);
            this.OrganizationalUnitTextBox.Name = "OrganizationalUnitTextBox";
            this.OrganizationalUnitTextBox.NullText = "Security";
            this.OrganizationalUnitTextBox.Size = new System.Drawing.Size(237, 24);
            this.OrganizationalUnitTextBox.TabIndex = 6;
            this.OrganizationalUnitTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(266, 12);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(103, 18);
            this.radLabel9.TabIndex = 15;
            this.radLabel9.Text = "Organizational Unit";
            this.radLabel9.ThemeName = "VisualStudio2012Dark";
            // 
            // CommonNameTextBox
            // 
            this.CommonNameTextBox.Location = new System.Drawing.Point(266, 90);
            this.CommonNameTextBox.Name = "CommonNameTextBox";
            this.CommonNameTextBox.NullText = "nahaanbin.com";
            this.CommonNameTextBox.Size = new System.Drawing.Size(237, 24);
            this.CommonNameTextBox.TabIndex = 7;
            this.CommonNameTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(266, 66);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(85, 18);
            this.radLabel10.TabIndex = 17;
            this.radLabel10.Text = "Common Name";
            this.radLabel10.ThemeName = "VisualStudio2012Dark";
            // 
            // PrivateKeyPasswordTextBox
            // 
            this.PrivateKeyPasswordTextBox.Location = new System.Drawing.Point(266, 144);
            this.PrivateKeyPasswordTextBox.Name = "PrivateKeyPasswordTextBox";
            this.PrivateKeyPasswordTextBox.Size = new System.Drawing.Size(237, 24);
            this.PrivateKeyPasswordTextBox.TabIndex = 8;
            this.PrivateKeyPasswordTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel11
            // 
            this.radLabel11.Location = new System.Drawing.Point(266, 120);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(111, 18);
            this.radLabel11.TabIndex = 19;
            this.radLabel11.Text = "Private Key Password";
            this.radLabel11.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel12
            // 
            this.radLabel12.Location = new System.Drawing.Point(12, 228);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(47, 18);
            this.radLabel12.TabIndex = 20;
            this.radLabel12.Text = "Key Size";
            this.radLabel12.ThemeName = "VisualStudio2012Dark";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(266, 198);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.NullText = "admin@nahaanbin.com";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(237, 24);
            this.EmailAddressTextBox.TabIndex = 9;
            this.EmailAddressTextBox.ThemeName = "VisualStudio2012Dark";
            this.EmailAddressTextBox.Click += new System.EventHandler(this.EmailAddressTextBox_Click);
            // 
            // radLabel13
            // 
            this.radLabel13.Location = new System.Drawing.Point(266, 174);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(76, 18);
            this.radLabel13.TabIndex = 22;
            this.radLabel13.Text = "Email Address";
            this.radLabel13.ThemeName = "VisualStudio2012Dark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abdal_CSR_Generator.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(555, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radLabelElement2,
            this.radLabelElement3,
            this.radLabelElement4});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 316);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(813, 26);
            this.radStatusStrip1.TabIndex = 24;
            this.radStatusStrip1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radStatusStrip1.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radStatusStrip1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(230)))));
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.ForeColor = System.Drawing.Color.White;
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "Programmer : Ebrahim Shafiei (EbraSha)";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.UseCompatibleTextRendering = false;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.ForeColor = System.Drawing.Color.White;
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusStrip1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "|  Prof.Shafiei@Gmail.com";
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.UseCompatibleTextRendering = false;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusStrip1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "";
            this.radLabelElement3.TextWrap = true;
            this.radLabelElement3.UseCompatibleTextRendering = false;
            // 
            // radLabelElement4
            // 
            this.radLabelElement4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radLabelElement4.Name = "radLabelElement4";
            this.radStatusStrip1.SetSpring(this.radLabelElement4, false);
            this.radLabelElement4.Text = "| Powered By Abdal Security Agency ";
            this.radLabelElement4.TextWrap = true;
            this.radLabelElement4.UseCompatibleTextRendering = false;
            // 
            // backgroundWorkerCsr
            // 
            this.backgroundWorkerCsr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCsr_DoWork);
            this.backgroundWorkerCsr.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCsr_ProgressChanged);
            this.backgroundWorkerCsr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCsr_RunWorkerCompleted);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(555, 271);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(220, 24);
            this.radWaitingBar1.TabIndex = 25;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "VisualStudio2012Dark";
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement2);
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            // 
            // waitingBarIndicatorElement1
            // 
            this.waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            this.waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement2
            // 
            this.waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            this.waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // Abdal_AES_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 342);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.radLabel13);
            this.Controls.Add(this.radLabel12);
            this.Controls.Add(this.PrivateKeyPasswordTextBox);
            this.Controls.Add(this.CommonNameTextBox);
            this.Controls.Add(this.radLabel11);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.OrganizationalUnitTextBox);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.OrganizationTextBox);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.LocalityTextBox);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.EncDecButton);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.keySizeToggleSwitch);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Abdal_AES_Encryption";
            this.Opacity = 0.9D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abdal CSR Generator";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Abdal_2Key_Triple_DES_Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySizeToggleSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationalUnitTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommonNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrivateKeyPasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailAddressTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleSwitch keySizeToggleSwitch;
        private Telerik.WinControls.UI.RadTextBox CountryTextBox;
        private Telerik.WinControls.UI.RadButton EncDecButton;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadTextBox StateTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox OrganizationTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox LocalityTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadTextBox OrganizationalUnitTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadTextBox CommonNameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadTextBox PrivateKeyPasswordTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadTextBox EmailAddressTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCsr;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
    }
}

