
namespace XCOM2ModLauncherNoSteam
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.xcom2_install_loc_txtbx = new System.Windows.Forms.TextBox();
            this.xcom2_mods_clb = new System.Windows.Forms.CheckedListBox();
            this.refresh_mods_btn = new System.Windows.Forms.Button();
            this.launch_xcom2_btn = new System.Windows.Forms.Button();
            this.open_modfldr_btn = new System.Windows.Forms.Button();
            this.xcom2_install_browse_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XCOM 2 Install Location";
            // 
            // xcom2_install_loc_txtbx
            // 
            this.xcom2_install_loc_txtbx.Location = new System.Drawing.Point(139, 6);
            this.xcom2_install_loc_txtbx.Name = "xcom2_install_loc_txtbx";
            this.xcom2_install_loc_txtbx.Size = new System.Drawing.Size(304, 20);
            this.xcom2_install_loc_txtbx.TabIndex = 1;
            // 
            // xcom2_mods_clb
            // 
            this.xcom2_mods_clb.FormattingEnabled = true;
            this.xcom2_mods_clb.Location = new System.Drawing.Point(12, 77);
            this.xcom2_mods_clb.Name = "xcom2_mods_clb";
            this.xcom2_mods_clb.Size = new System.Drawing.Size(744, 484);
            this.xcom2_mods_clb.TabIndex = 2;
            // 
            // refresh_mods_btn
            // 
            this.refresh_mods_btn.Location = new System.Drawing.Point(15, 48);
            this.refresh_mods_btn.Name = "refresh_mods_btn";
            this.refresh_mods_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_mods_btn.TabIndex = 3;
            this.refresh_mods_btn.Text = "Refresh";
            this.refresh_mods_btn.UseVisualStyleBackColor = true;
            this.refresh_mods_btn.Click += new System.EventHandler(this.refresh_mods_btn_Click);
            // 
            // launch_xcom2_btn
            // 
            this.launch_xcom2_btn.Location = new System.Drawing.Point(638, 582);
            this.launch_xcom2_btn.Name = "launch_xcom2_btn";
            this.launch_xcom2_btn.Size = new System.Drawing.Size(118, 23);
            this.launch_xcom2_btn.TabIndex = 4;
            this.launch_xcom2_btn.Text = "Launch XCOM 2";
            this.launch_xcom2_btn.UseVisualStyleBackColor = true;
            this.launch_xcom2_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_modfldr_btn
            // 
            this.open_modfldr_btn.Location = new System.Drawing.Point(96, 48);
            this.open_modfldr_btn.Name = "open_modfldr_btn";
            this.open_modfldr_btn.Size = new System.Drawing.Size(102, 23);
            this.open_modfldr_btn.TabIndex = 5;
            this.open_modfldr_btn.Text = "Open Mod Folder";
            this.open_modfldr_btn.UseVisualStyleBackColor = true;
            this.open_modfldr_btn.Click += new System.EventHandler(this.open_modfldr_btn_Click);
            // 
            // xcom2_install_browse_btn
            // 
            this.xcom2_install_browse_btn.Location = new System.Drawing.Point(449, 4);
            this.xcom2_install_browse_btn.Name = "xcom2_install_browse_btn";
            this.xcom2_install_browse_btn.Size = new System.Drawing.Size(75, 23);
            this.xcom2_install_browse_btn.TabIndex = 6;
            this.xcom2_install_browse_btn.Text = "Browse";
            this.xcom2_install_browse_btn.UseVisualStyleBackColor = true;
            this.xcom2_install_browse_btn.Click += new System.EventHandler(this.xcom2_install_browse_btn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 617);
            this.Controls.Add(this.xcom2_install_browse_btn);
            this.Controls.Add(this.open_modfldr_btn);
            this.Controls.Add(this.launch_xcom2_btn);
            this.Controls.Add(this.refresh_mods_btn);
            this.Controls.Add(this.xcom2_mods_clb);
            this.Controls.Add(this.xcom2_install_loc_txtbx);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "No Steam XCOM2 Mod Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xcom2_install_loc_txtbx;
        private System.Windows.Forms.CheckedListBox xcom2_mods_clb;
        private System.Windows.Forms.Button refresh_mods_btn;
        private System.Windows.Forms.Button launch_xcom2_btn;
        private System.Windows.Forms.Button open_modfldr_btn;
        private System.Windows.Forms.Button xcom2_install_browse_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

