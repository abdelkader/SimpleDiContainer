namespace SimpleDiContainer
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
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this._dgvUsers = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnUpdate = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtFirstName = new System.Windows.Forms.TextBox();
            this._txtLastName = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvUsers)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.panel.ColumnCount = 2;
            this.panel.RowCount = 6;
            this.panel.Controls.Add(this._dgvUsers, 0, 0);
            this.panel.Controls.Add(this.buttonPanel, 0, 5);
            this.panel.Controls.Add(this.label1, 0, 1);
            this.panel.Controls.Add(this.label2, 0, 2);
            this.panel.Controls.Add(this.label3, 0, 3);
            this.panel.Controls.Add(this._txtFirstName, 1, 1);
            this.panel.Controls.Add(this._txtLastName, 1, 2);
            this.panel.Controls.Add(this._txtEmail, 1, 3);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Padding = new System.Windows.Forms.Padding(10);
            this.panel.SetColumnSpan(this._dgvUsers, 2);
            // 
            // _dgvUsers
            // 
            this._dgvUsers.AllowUserToAddRows = false;
            this._dgvUsers.AllowUserToDeleteRows = false;
            this._dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvUsers.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.panel.SetColumnSpan(this.buttonPanel, 2);
            this.buttonPanel.Controls.Add(this._btnLoad);
            this.buttonPanel.Controls.Add(this._btnAdd);
            this.buttonPanel.Controls.Add(this._btnUpdate);
            this.buttonPanel.Controls.Add(this._btnDelete);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // Load Button
            // 
            this._btnLoad.Location = new System.Drawing.Point(3, 3);
            this._btnLoad.Size = new System.Drawing.Size(75, 23);
            this._btnLoad.TabIndex = 0;
            this._btnLoad.Text = "Load";
            this._btnLoad.UseVisualStyleBackColor = true;
            // 
            // Add Button
            // 
            this._btnAdd.Location = new System.Drawing.Point(84, 3);
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            // 
            // Modify Button
            // 
            this._btnUpdate.Location = new System.Drawing.Point(165, 3);
            this._btnUpdate.Size = new System.Drawing.Size(75, 23);
            this._btnUpdate.TabIndex = 2;
            this._btnUpdate.Text = "Modify";
            this._btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Delete Button
            // 
            this._btnDelete.Location = new System.Drawing.Point(246, 3);
            this._btnDelete.Size = new System.Drawing.Size(75, 23);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "Delete";
            this._btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // _txtFirstName
            // 
            this._txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtFirstName.TabIndex = 5;
            // 
            // _txtLastName
            // 
            this._txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtLastName.TabIndex = 6;
            // 
            // _txtEmail
            // 
            this._txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtEmail.TabIndex = 7;
            // 
            // MainForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.panel);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users management";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvUsers)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.DataGridView _dgvUsers;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button _btnLoad;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnUpdate;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtFirstName;
        private System.Windows.Forms.TextBox _txtLastName;
        private System.Windows.Forms.TextBox _txtEmail;
    }
}