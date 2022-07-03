
namespace StudentReg
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feesText = new System.Windows.Forms.TextBox();
            this.courceText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadDetailsGV = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDetailsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feesText);
            this.groupBox1.Controls.Add(this.courceText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // feesText
            // 
            this.feesText.Location = new System.Drawing.Point(160, 308);
            this.feesText.Name = "feesText";
            this.feesText.Size = new System.Drawing.Size(210, 26);
            this.feesText.TabIndex = 5;
            // 
            // courceText
            // 
            this.courceText.Location = new System.Drawing.Point(160, 171);
            this.courceText.Name = "courceText";
            this.courceText.Size = new System.Drawing.Size(210, 26);
            this.courceText.TabIndex = 4;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(160, 61);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(210, 26);
            this.nameText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cource";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // loadDetailsGV
            // 
            this.loadDetailsGV.AllowUserToAddRows = false;
            this.loadDetailsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDetailsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.EditID,
            this.DeleteID});
            this.loadDetailsGV.Location = new System.Drawing.Point(437, 186);
            this.loadDetailsGV.Name = "loadDetailsGV";
            this.loadDetailsGV.RowHeadersWidth = 62;
            this.loadDetailsGV.RowTemplate.Height = 28;
            this.loadDetailsGV.Size = new System.Drawing.Size(790, 333);
            this.loadDetailsGV.TabIndex = 2;
            this.loadDetailsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadDetailsGV_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(60, 556);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 36);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(283, 556);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 36);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student_Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Course_Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fee";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // EditID
            // 
            this.EditID.HeaderText = "Edit";
            this.EditID.MinimumWidth = 8;
            this.EditID.Name = "EditID";
            this.EditID.Text = "Edit";
            this.EditID.UseColumnTextForButtonValue = true;
            this.EditID.Width = 150;
            // 
            // DeleteID
            // 
            this.DeleteID.HeaderText = "Delete";
            this.DeleteID.MinimumWidth = 8;
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Text = "Delete";
            this.DeleteID.UseColumnTextForButtonValue = true;
            this.DeleteID.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 627);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadDetailsGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDetailsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox feesText;
        private System.Windows.Forms.TextBox courceText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView loadDetailsGV;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn EditID;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteID;
    }
}

