namespace Lab_Form
{
    partial class Frm_M26_Arry
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
            this.btnArry = new System.Windows.Forms.Button();
            this.btnArrySecond = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArry
            // 
            this.btnArry.Location = new System.Drawing.Point(58, 52);
            this.btnArry.Name = "btnArry";
            this.btnArry.Size = new System.Drawing.Size(111, 70);
            this.btnArry.TabIndex = 0;
            this.btnArry.Text = "陣列顯示";
            this.btnArry.UseVisualStyleBackColor = true;
            this.btnArry.Click += new System.EventHandler(this.btnArry_Click);
            // 
            // btnArrySecond
            // 
            this.btnArrySecond.Location = new System.Drawing.Point(58, 155);
            this.btnArrySecond.Name = "btnArrySecond";
            this.btnArrySecond.Size = new System.Drawing.Size(111, 70);
            this.btnArrySecond.TabIndex = 1;
            this.btnArrySecond.Text = "二維陣列顯示";
            this.btnArrySecond.UseVisualStyleBackColor = true;
            this.btnArrySecond.Click += new System.EventHandler(this.btnArrySecond_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "類別陣列顯示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_M26_Arry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArrySecond);
            this.Controls.Add(this.btnArry);
            this.Name = "Frm_M26_Arry";
            this.Text = "Frm_M26_Arry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArry;
        private System.Windows.Forms.Button btnArry2;
        private System.Windows.Forms.Button btnArrySecond;
        private System.Windows.Forms.Button button1;
    }
}