namespace Lab_Form
{
    partial class Frm_M28_進階方法
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOverLoadSwap = new System.Windows.Forms.Button();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOverLoadSwap);
            this.groupBox1.Location = new System.Drawing.Point(50, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Over Load";
            // 
            // btnOverLoadSwap
            // 
            this.btnOverLoadSwap.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOverLoadSwap.Location = new System.Drawing.Point(21, 36);
            this.btnOverLoadSwap.Name = "btnOverLoadSwap";
            this.btnOverLoadSwap.Size = new System.Drawing.Size(253, 65);
            this.btnOverLoadSwap.TabIndex = 0;
            this.btnOverLoadSwap.Text = "Swap int a , int b";
            this.btnOverLoadSwap.UseVisualStyleBackColor = true;
            this.btnOverLoadSwap.Click += new System.EventHandler(this.btnOverLoadSwap_Click);
            // 
            // btnGeneric
            // 
            this.btnGeneric.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGeneric.Location = new System.Drawing.Point(410, 67);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(253, 65);
            this.btnGeneric.TabIndex = 1;
            this.btnGeneric.Text = "泛用方法";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // Frm_M28_進階方法
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneric);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_M28_進階方法";
            this.Text = "Frm_M28_進階方法";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOverLoadSwap;
        private System.Windows.Forms.Button btnGeneric;
    }
}