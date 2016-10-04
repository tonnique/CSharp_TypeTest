namespace TypeTest
{
    partial class frmTyper
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rchTxtBoxTask = new System.Windows.Forms.RichTextBox();
            this.rchTxtBoxUser = new System.Windows.Forms.RichTextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.numUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblErrorsText = new System.Windows.Forms.Label();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rchTxtBoxTask);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rchTxtBoxUser);
            this.splitContainer1.Size = new System.Drawing.Size(790, 365);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 4;
            // 
            // rchTxtBoxTask
            // 
            this.rchTxtBoxTask.BackColor = System.Drawing.Color.White;
            this.rchTxtBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTxtBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rchTxtBoxTask.ForeColor = System.Drawing.Color.Black;
            this.rchTxtBoxTask.Location = new System.Drawing.Point(0, 0);
            this.rchTxtBoxTask.Name = "rchTxtBoxTask";
            this.rchTxtBoxTask.ReadOnly = true;
            this.rchTxtBoxTask.Size = new System.Drawing.Size(790, 208);
            this.rchTxtBoxTask.TabIndex = 4;
            this.rchTxtBoxTask.Text = "";
            // 
            // rchTxtBoxUser
            // 
            this.rchTxtBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTxtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rchTxtBoxUser.Location = new System.Drawing.Point(0, 0);
            this.rchTxtBoxUser.Name = "rchTxtBoxUser";
            this.rchTxtBoxUser.Size = new System.Drawing.Size(790, 153);
            this.rchTxtBoxUser.TabIndex = 1;
            this.rchTxtBoxUser.Text = "";
            this.rchTxtBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rchTxtBoxUser_KeyPress);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLang.Location = new System.Drawing.Point(2, 7);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(27, 16);
            this.lblLang.TabIndex = 6;
            this.lblLang.Text = "EN";
            this.lblLang.Click += new System.EventHandler(this.lblLang_Click);
            // 
            // cmbTask
            // 
            this.cmbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(33, 4);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(170, 24);
            this.cmbTask.TabIndex = 2;
            this.cmbTask.SelectedIndexChanged += new System.EventHandler(this.cmbTask_SelectedIndexChanged);
            // 
            // numUpDownMinutes
            // 
            this.numUpDownMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownMinutes.Location = new System.Drawing.Point(466, 7);
            this.numUpDownMinutes.Name = "numUpDownMinutes";
            this.numUpDownMinutes.Size = new System.Drawing.Size(77, 22);
            this.numUpDownMinutes.TabIndex = 3;
            this.numUpDownMinutes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblErrorsText
            // 
            this.lblErrorsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorsText.AutoSize = true;
            this.lblErrorsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorsText.Location = new System.Drawing.Point(571, 11);
            this.lblErrorsText.Name = "lblErrorsText";
            this.lblErrorsText.Size = new System.Drawing.Size(47, 16);
            this.lblErrorsText.TabIndex = 9;
            this.lblErrorsText.Text = "Errors:";
            // 
            // lblTimeText
            // 
            this.lblTimeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeText.Location = new System.Drawing.Point(660, 12);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(45, 16);
            this.lblTimeText.TabIndex = 10;
            this.lblTimeText.Text = "Time: ";
            // 
            // lblMins
            // 
            this.lblMins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMins.Location = new System.Drawing.Point(406, 11);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(54, 17);
            this.lblMins.TabIndex = 11;
            this.lblMins.Text = "Minutes";
            // 
            // lblErrors
            // 
            this.lblErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrors.Location = new System.Drawing.Point(614, 12);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(29, 16);
            this.lblErrors.TabIndex = 12;
            this.lblErrors.Text = "000";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(699, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(15, 16);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(720, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblTimeText);
            this.Controls.Add(this.lblErrorsText);
            this.Controls.Add(this.numUpDownMinutes);
            this.Controls.Add(this.cmbTask);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(810, 444);
            this.Name = "frmTyper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypingTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTyper_FormClosed);
            this.Shown += new System.EventHandler(this.frmTyper_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rchTxtBoxTask;
        private System.Windows.Forms.RichTextBox rchTxtBoxUser;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.NumericUpDown numUpDownMinutes;
        private System.Windows.Forms.Label lblErrorsText;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancel;
    }
}

