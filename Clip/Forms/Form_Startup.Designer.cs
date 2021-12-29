
using System.Windows.Forms;

namespace Clip.Forms
{
    partial class Form_Startup : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataGridView_ClipboardContents = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Setting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ClipboardContents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DataGridView_ClipboardContents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(300, 485);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataGridView_ClipboardContents
            // 
            this.DataGridView_ClipboardContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ClipboardContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_ClipboardContents.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_ClipboardContents.Name = "DataGridView_ClipboardContents";
            this.DataGridView_ClipboardContents.RowTemplate.Height = 25;
            this.DataGridView_ClipboardContents.Size = new System.Drawing.Size(300, 447);
            this.DataGridView_ClipboardContents.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Setting);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 37);
            this.panel1.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Add.BackColor = System.Drawing.Color.Transparent;
            this.Button_Add.BackgroundImage = global::Clip.Properties.Resources.add;
            this.Button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Add.Location = new System.Drawing.Point(3, 6);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(28, 28);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Button_Setting
            // 
            this.Button_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Setting.BackColor = System.Drawing.Color.Transparent;
            this.Button_Setting.BackgroundImage = global::Clip.Properties.Resources.setting;
            this.Button_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Setting.FlatAppearance.BorderSize = 0;
            this.Button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Setting.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Setting.Location = new System.Drawing.Point(269, 6);
            this.Button_Setting.Name = "Button_Setting";
            this.Button_Setting.Size = new System.Drawing.Size(28, 28);
            this.Button_Setting.TabIndex = 1;
            this.Button_Setting.UseVisualStyleBackColor = false;
            // 
            // Form_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 485);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Startup";
            this.Text = "Clip";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ClipboardContents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DataGridView_ClipboardContents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_Setting;
        private System.Windows.Forms.Button Button_Add;
    }
}

