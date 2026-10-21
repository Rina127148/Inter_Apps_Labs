namespace RaceLog
{
    partial class Form1
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
            txtDriver = new TextBox();
            btnAdd = new Button();
            lstResults = new ListBox();
            lblStatus = new Label();
            lblDriver = new Label();
            cmbCar = new ComboBox();
            cmbTrack = new ComboBox();
            txtTime = new TextBox();
            btnDelete = new Button();
            btnClear = new Button();
            lblCar = new Label();
            lblTrack = new Label();
            lblTime = new Label();
            lblResults = new Label();
            SuspendLayout();
            // 
            // txtDriver
            // 
            txtDriver.Location = new Point(25, 66);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(328, 30);
            txtDriver.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(388, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.Location = new Point(388, 66);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(461, 234);
            lstResults.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Location = new Point(25, 401);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(328, 27);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Введите имя пилота";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.BackColor = SystemColors.Info;
            lblDriver.Location = new Point(25, 29);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(58, 23);
            lblDriver.TabIndex = 4;
            lblDriver.Text = "Пилот";
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.FormattingEnabled = true;
            cmbCar.Items.AddRange(new object[] { "Street", "Sport", "Prototype" });
            cmbCar.Location = new Point(25, 148);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(328, 31);
            cmbCar.TabIndex = 1;
            // 
            // cmbTrack
            // 
            cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrack.FormattingEnabled = true;
            cmbTrack.Items.AddRange(new object[] { "Учебный овал", "Городское кольцо", "Спринт" });
            cmbTrack.Location = new Point(25, 237);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(328, 31);
            cmbTrack.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(25, 329);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(328, 30);
            txtTime.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(498, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить выбранную";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(698, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Очистить поля";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.BackColor = SystemColors.Info;
            lblCar.Location = new Point(25, 109);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(107, 23);
            lblCar.TabIndex = 10;
            lblCar.Text = "Автомобиль";
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.BackColor = SystemColors.Info;
            lblTrack.Location = new Point(25, 196);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(63, 23);
            lblTrack.TabIndex = 11;
            lblTrack.Text = "Трасса";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = SystemColors.Info;
            lblTime.Location = new Point(25, 288);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(124, 23);
            lblTime.TabIndex = 12;
            lblTime.Text = "Время круга, с";
            lblTime.Click += lblTime_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.BackColor = SystemColors.Info;
            lblResults.Location = new Point(539, 29);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(165, 23);
            lblResults.TabIndex = 13;
            lblResults.Text = "Результаты заездов";
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 453);
            Controls.Add(lblResults);
            Controls.Add(lblTime);
            Controls.Add(lblTrack);
            Controls.Add(lblCar);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(txtTime);
            Controls.Add(cmbTrack);
            Controls.Add(cmbCar);
            Controls.Add(lblDriver);
            Controls.Add(lblStatus);
            Controls.Add(lstResults);
            Controls.Add(btnAdd);
            Controls.Add(txtDriver);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Журнал заездов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDriver;
        private Button btnAdd;
        private ListBox lstResults;
        private Label lblStatus;
        private Label lblDriver;
        private ComboBox cmbTrack;
        private ComboBox cmbCar;
        private TextBox txtTime;
        private Button btnDelete;
        private Button btnClear;
        private Label lblCar;
        private Label lblTrack;
        private Label lblTime;
        private Label lblResults;
    }
}
