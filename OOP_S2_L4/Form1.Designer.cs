namespace OOP_S2_L4
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
            this.createMatrixBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.rowsInputLabel = new System.Windows.Forms.Label();
            this.minNumberLabel = new System.Windows.Forms.Label();
            this.colsInputLabel = new System.Windows.Forms.Label();
            this.maxNumberLabel = new System.Windows.Forms.Label();
            this.colsTextBox = new System.Windows.Forms.TextBox();
            this.minNumberTextBox = new System.Windows.Forms.TextBox();
            this.maxNumberTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstColumnTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createMatrixBtn
            // 
            this.createMatrixBtn.Location = new System.Drawing.Point(16, 80);
            this.createMatrixBtn.Name = "createMatrixBtn";
            this.createMatrixBtn.Size = new System.Drawing.Size(115, 26);
            this.createMatrixBtn.TabIndex = 0;
            this.createMatrixBtn.Text = "Створити матрицю";
            this.createMatrixBtn.UseVisualStyleBackColor = true;
            this.createMatrixBtn.Click += new System.EventHandler(this.createMatrixBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Визначити ->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.findFirstZeroNegativesColumnBtn_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(547, 23);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(119, 46);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортувати";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.Location = new System.Drawing.Point(12, -2);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(185, 24);
            this.titleLable.TabIndex = 3;
            this.titleLable.Text = "Параметри матриці";
            this.titleLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // rowsInputLabel
            // 
            this.rowsInputLabel.AutoSize = true;
            this.rowsInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsInputLabel.Location = new System.Drawing.Point(12, 25);
            this.rowsInputLabel.Name = "rowsInputLabel";
            this.rowsInputLabel.Size = new System.Drawing.Size(99, 20);
            this.rowsInputLabel.TabIndex = 4;
            this.rowsInputLabel.Text = "К-ть рядків:";
            this.rowsInputLabel.Click += new System.EventHandler(this.rowsInputLabel_Click);
            // 
            // minNumberLabel
            // 
            this.minNumberLabel.AutoSize = true;
            this.minNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minNumberLabel.Location = new System.Drawing.Point(287, 25);
            this.minNumberLabel.Name = "minNumberLabel";
            this.minNumberLabel.Size = new System.Drawing.Size(91, 20);
            this.minNumberLabel.TabIndex = 5;
            this.minNumberLabel.Text = "Мін. число:";
            // 
            // colsInputLabel
            // 
            this.colsInputLabel.AutoSize = true;
            this.colsInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colsInputLabel.Location = new System.Drawing.Point(12, 51);
            this.colsInputLabel.Name = "colsInputLabel";
            this.colsInputLabel.Size = new System.Drawing.Size(115, 20);
            this.colsInputLabel.TabIndex = 6;
            this.colsInputLabel.Text = "К-ть стовпців:";
            // 
            // maxNumberLabel
            // 
            this.maxNumberLabel.AutoSize = true;
            this.maxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxNumberLabel.Location = new System.Drawing.Point(287, 51);
            this.maxNumberLabel.Name = "maxNumberLabel";
            this.maxNumberLabel.Size = new System.Drawing.Size(104, 20);
            this.maxNumberLabel.TabIndex = 7;
            this.maxNumberLabel.Text = "Макс. число:";
            // 
            // colsTextBox
            // 
            this.colsTextBox.Location = new System.Drawing.Point(139, 51);
            this.colsTextBox.Name = "colsTextBox";
            this.colsTextBox.Size = new System.Drawing.Size(82, 20);
            this.colsTextBox.TabIndex = 9;
            this.colsTextBox.TextChanged += new System.EventHandler(this.colsTextBox2_TextChanged);
            this.colsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colsTextBox_KeyPress);
            // 
            // minNumberTextBox
            // 
            this.minNumberTextBox.Location = new System.Drawing.Point(393, 25);
            this.minNumberTextBox.Name = "minNumberTextBox";
            this.minNumberTextBox.Size = new System.Drawing.Size(84, 20);
            this.minNumberTextBox.TabIndex = 10;
            this.minNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minNumberTextBox3_KeyPress);
            // 
            // maxNumberTextBox
            // 
            this.maxNumberTextBox.Location = new System.Drawing.Point(393, 49);
            this.maxNumberTextBox.Name = "maxNumberTextBox";
            this.maxNumberTextBox.Size = new System.Drawing.Size(84, 20);
            this.maxNumberTextBox.TabIndex = 11;
            this.maxNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxNumberTextBox4_KeyPress);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(16, 112);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(650, 319);
            this.dataGridView.TabIndex = 12;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(139, 25);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(82, 20);
            this.rowsTextBox.TabIndex = 13;
            this.rowsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.rowsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowsTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер першого стовпця без від\'ємних чисел:";
            // 
            // firstColumnTextBox
            // 
            this.firstColumnTextBox.Enabled = false;
            this.firstColumnTextBox.Location = new System.Drawing.Point(547, 81);
            this.firstColumnTextBox.Name = "firstColumnTextBox";
            this.firstColumnTextBox.ReadOnly = true;
            this.firstColumnTextBox.Size = new System.Drawing.Size(119, 20);
            this.firstColumnTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 443);
            this.Controls.Add(this.firstColumnTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.maxNumberTextBox);
            this.Controls.Add(this.minNumberTextBox);
            this.Controls.Add(this.colsTextBox);
            this.Controls.Add(this.maxNumberLabel);
            this.Controls.Add(this.colsInputLabel);
            this.Controls.Add(this.minNumberLabel);
            this.Controls.Add(this.rowsInputLabel);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createMatrixBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createMatrixBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label rowsInputLabel;
        private System.Windows.Forms.Label minNumberLabel;
        private System.Windows.Forms.Label colsInputLabel;
        private System.Windows.Forms.Label maxNumberLabel;
        private System.Windows.Forms.TextBox colsTextBox;
        private System.Windows.Forms.TextBox minNumberTextBox;
        private System.Windows.Forms.TextBox maxNumberTextBox;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstColumnTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

