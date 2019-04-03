namespace BengkelAtma.Menu
{
    partial class Akun
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.findHeader = new MetroFramework.Controls.MetroPanel();
            this.btnCari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgContainer = new MetroFramework.Controls.MetroPanel();
            this.dgAkun = new System.Windows.Forms.DataGridView();
            this.bootomContent = new MetroFramework.Controls.MetroPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.oldPass = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.findHeader.SuspendLayout();
            this.dgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).BeginInit();
            this.bootomContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgContainer);
            this.panel1.Controls.Add(this.findHeader);
            this.panel1.Controls.Add(this.bootomContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 400);
            this.panel1.TabIndex = 0;
            // 
            // findHeader
            // 
            this.findHeader.BackColor = System.Drawing.Color.White;
            this.findHeader.Controls.Add(this.btnCari);
            this.findHeader.Controls.Add(this.label1);
            this.findHeader.Controls.Add(this.textBox2);
            this.findHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.findHeader.HorizontalScrollbarBarColor = true;
            this.findHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.findHeader.HorizontalScrollbarSize = 10;
            this.findHeader.Location = new System.Drawing.Point(0, 0);
            this.findHeader.Name = "findHeader";
            this.findHeader.Size = new System.Drawing.Size(320, 82);
            this.findHeader.TabIndex = 16;
            this.findHeader.VerticalScrollbarBarColor = true;
            this.findHeader.VerticalScrollbarHighlightOnWheel = false;
            this.findHeader.VerticalScrollbarSize = 10;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(225, 53);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(49, 23);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kata Kunci:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 10;
            // 
            // dgContainer
            // 
            this.dgContainer.BackColor = System.Drawing.Color.White;
            this.dgContainer.Controls.Add(this.dgAkun);
            this.dgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgContainer.HorizontalScrollbarBarColor = true;
            this.dgContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.dgContainer.HorizontalScrollbarSize = 10;
            this.dgContainer.Location = new System.Drawing.Point(0, 82);
            this.dgContainer.Name = "dgContainer";
            this.dgContainer.Padding = new System.Windows.Forms.Padding(10);
            this.dgContainer.Size = new System.Drawing.Size(320, 218);
            this.dgContainer.TabIndex = 15;
            this.dgContainer.VerticalScrollbarBarColor = true;
            this.dgContainer.VerticalScrollbarHighlightOnWheel = false;
            this.dgContainer.VerticalScrollbarSize = 10;
            // 
            // dgAkun
            // 
            this.dgAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAkun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkun.Location = new System.Drawing.Point(10, 10);
            this.dgAkun.Name = "dgAkun";
            this.dgAkun.Size = new System.Drawing.Size(300, 198);
            this.dgAkun.TabIndex = 13;
            // 
            // bootomContent
            // 
            this.bootomContent.BackColor = System.Drawing.Color.White;
            this.bootomContent.Controls.Add(this.btnEdit);
            this.bootomContent.Controls.Add(this.btnDelete);
            this.bootomContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bootomContent.HorizontalScrollbarBarColor = true;
            this.bootomContent.HorizontalScrollbarHighlightOnWheel = false;
            this.bootomContent.HorizontalScrollbarSize = 10;
            this.bootomContent.Location = new System.Drawing.Point(0, 300);
            this.bootomContent.Name = "bootomContent";
            this.bootomContent.Size = new System.Drawing.Size(320, 100);
            this.bootomContent.TabIndex = 14;
            this.bootomContent.VerticalScrollbarBarColor = true;
            this.bootomContent.VerticalScrollbarHighlightOnWheel = false;
            this.bootomContent.VerticalScrollbarSize = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Controls.Add(this.tbOldPass);
            this.panel2.Controls.Add(this.oldPass);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 400);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 9;
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Location = new System.Drawing.Point(26, 119);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(78, 13);
            this.newPass.TabIndex = 8;
            this.newPass.Text = "Password Baru";
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(29, 92);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(236, 20);
            this.tbOldPass.TabIndex = 7;
            // 
            // oldPass
            // 
            this.oldPass.AutoSize = true;
            this.oldPass.Location = new System.Drawing.Point(26, 76);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(82, 13);
            this.oldPass.TabIndex = 4;
            this.oldPass.Text = "Password Lama";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(111, 183);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(28, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 400);
            this.panel3.TabIndex = 11;
            // 
            // Akun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "Akun";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel1.ResumeLayout(false);
            this.findHeader.ResumeLayout(false);
            this.findHeader.PerformLayout();
            this.dgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).EndInit();
            this.bootomContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label oldPass;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label newPass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.DataGridView dgAkun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroPanel findHeader;
        private MetroFramework.Controls.MetroPanel dgContainer;
        private MetroFramework.Controls.MetroPanel bootomContent;
        private System.Windows.Forms.Panel panel3;
    }
}
