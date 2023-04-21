namespace Lab_Form
{
    partial class Frm_M08
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
            this.btnRegisterEvent = new System.Windows.Forms.Button();
            this.btnRegisterEvent01 = new System.Windows.Forms.Button();
            this.btnRegisterEvent02 = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterEvent
            // 
            this.btnRegisterEvent.Location = new System.Drawing.Point(63, 41);
            this.btnRegisterEvent.Name = "btnRegisterEvent";
            this.btnRegisterEvent.Size = new System.Drawing.Size(148, 46);
            this.btnRegisterEvent.TabIndex = 0;
            this.btnRegisterEvent.Text = "Register Event";
            this.btnRegisterEvent.UseVisualStyleBackColor = true;
            this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            // 
            // btnRegisterEvent01
            // 
            this.btnRegisterEvent01.Location = new System.Drawing.Point(63, 118);
            this.btnRegisterEvent01.Name = "btnRegisterEvent01";
            this.btnRegisterEvent01.Size = new System.Drawing.Size(148, 46);
            this.btnRegisterEvent01.TabIndex = 1;
            this.btnRegisterEvent01.Text = "Register Event 01";
            this.btnRegisterEvent01.UseVisualStyleBackColor = true;
            // 
            // btnRegisterEvent02
            // 
            this.btnRegisterEvent02.Location = new System.Drawing.Point(63, 194);
            this.btnRegisterEvent02.Name = "btnRegisterEvent02";
            this.btnRegisterEvent02.Size = new System.Drawing.Size(148, 46);
            this.btnRegisterEvent02.TabIndex = 2;
            this.btnRegisterEvent02.Text = "Register Event 02";
            this.btnRegisterEvent02.UseVisualStyleBackColor = true;
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(63, 273);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(148, 46);
            this.btnCancelRegister.TabIndex = 3;
            this.btnCancelRegister.Text = "解除Register Event ";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(302, 41);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(148, 46);
            this.btnMessageBox.TabIndex = 4;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open Hello Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(359, 155);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50% off",
            "20% off"});
            this.cmbDiscount.Location = new System.Drawing.Point(350, 194);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(121, 20);
            this.cmbDiscount.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(338, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "計算折扣";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Frm_M08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.btnRegisterEvent02);
            this.Controls.Add(this.btnRegisterEvent01);
            this.Controls.Add(this.btnRegisterEvent);
            this.Name = "Frm_M08";
            this.Text = "Frm_M08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterEvent;
        private System.Windows.Forms.Button btnRegisterEvent01;
        private System.Windows.Forms.Button btnRegisterEvent02;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button btnCalculate;
    }
}