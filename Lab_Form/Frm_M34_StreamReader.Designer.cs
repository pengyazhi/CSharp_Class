namespace Lab_Form
{
    partial class Frm_M34_StreamReader
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
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.txtReadWrite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBreakMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(41, 48);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(125, 63);
            this.btnStreamReader.TabIndex = 0;
            this.btnStreamReader.Text = "StreamReader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // txtReadWrite
            // 
            this.txtReadWrite.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReadWrite.Location = new System.Drawing.Point(264, 48);
            this.txtReadWrite.Multiline = true;
            this.txtReadWrite.Name = "txtReadWrite";
            this.txtReadWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadWrite.Size = new System.Drawing.Size(481, 289);
            this.txtReadWrite.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "StreamWrite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBreakMode
            // 
            this.btnBreakMode.Location = new System.Drawing.Point(41, 261);
            this.btnBreakMode.Name = "btnBreakMode";
            this.btnBreakMode.Size = new System.Drawing.Size(125, 63);
            this.btnBreakMode.TabIndex = 3;
            this.btnBreakMode.Text = "中斷模式";
            this.btnBreakMode.UseVisualStyleBackColor = true;
            this.btnBreakMode.Click += new System.EventHandler(this.btnBreakMode_Click);
            // 
            // Frm_M34_StreamReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBreakMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReadWrite);
            this.Controls.Add(this.btnStreamReader);
            this.Name = "Frm_M34_StreamReader";
            this.Text = "Frm_M34_StreamReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.TextBox txtReadWrite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBreakMode;
    }
}