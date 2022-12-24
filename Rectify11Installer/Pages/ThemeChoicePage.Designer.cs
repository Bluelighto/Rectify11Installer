﻿namespace Rectify11Installer.Pages
{
    partial class ThemeChoicePage
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
            System.ComponentModel.ComponentResourceManager resources = new global::Rectify11Installer.Core.SingleAssemblyComponentResourceManager(typeof(Strings.Rectify11));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.themePreview = new System.Windows.Forms.PictureBox();
            this.themeTitle = new Rectify11Installer.Controls.DarkAwareLabel();
            this.themeSelection = new Rectify11Installer.Controls.DarkAwareLabel();
            this.patcherSelection = new Rectify11Installer.Controls.DarkAwareLabel();
            this.ultraRadio = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.secureRadio = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.themeSel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // themePreview
            // 
            this.themePreview.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.themePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.themePreview.Location = new System.Drawing.Point(0, 0);
            this.themePreview.Name = "lightPreview";
            this.themePreview.Size = new System.Drawing.Size(120, 98);
            this.themePreview.TabIndex = 0;
            this.themePreview.TabStop = false;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.themePreview, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 98);
            this.tableLayoutPanel1.TabStop = false;
            // 
            // themeTitle
            // 
            this.themeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeTitle.Name = "themeTitle";
            this.themeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themeTitle.Size = new System.Drawing.Size(361, 40);
            this.themeTitle.TabIndex = 3;
            this.themeTitle.Text = "Preview";
            // 
            // themeSelection
            // 
            this.themeSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 10.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeSelection.Name = "themeSelection";
            this.themeSelection.Location = new System.Drawing.Point(0, 158);
            this.themeSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themeSelection.Size = new System.Drawing.Size(361, 20);
            this.themeSelection.TabIndex = 5;
            this.themeSelection.Text = resources.GetString("themeChoiceTitle");
            //
            // themeSel
            //
            this.themeSel.Name = "themeSel";
            this.themeSel.Location = new System.Drawing.Point(200, 157);
            this.themeSel.Size = new System.Drawing.Size(140, 40);
            this.themeSel.TabIndex = 1;
            this.themeSel.Items.Add(resources.GetString("themeLight"));
            this.themeSel.Items.Add(resources.GetString("themeDark"));
            this.themeSel.Items.Add(resources.GetString("themeBlack"));
            this.themeSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // ThemeChoicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.themeTitle);
            this.Controls.Add(this.themeSel);
            this.Controls.Add(this.themeSelection);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThemeChoicePage";
            this.SideImage = global::Rectify11Installer.Properties.Resources.themepage;
            this.WizardHeader = resources.GetString("themeHeader");
            ((System.ComponentModel.ISupportInitialize)(this.themePreview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox themePreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.DarkAwareLabel themeTitle;
        private Controls.DarkAwareLabel themeSelection;
        private Controls.DarkAwareLabel patcherSelection;
        private Controls.DarkAwareRadioButton ultraRadio;
        private Controls.DarkAwareRadioButton secureRadio;
        private System.Windows.Forms.ComboBox themeSel;
    }
}
