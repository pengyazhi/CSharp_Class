namespace Lab_Form
{
    partial class Frm_M15_CTS
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.labReferenceType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Location = new System.Drawing.Point(57, 60);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(75, 23);
            this.btnValueType.TabIndex = 0;
            this.btnValueType.Text = "Value Type";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnValueType_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Location = new System.Drawing.Point(57, 172);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(142, 23);
            this.btnReferenceType.TabIndex = 1;
            this.btnReferenceType.Text = "Reference Type";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.btnReferenceType_Click);
            // 
            // labReferenceType
            // 
            this.labReferenceType.AutoSize = true;
            this.labReferenceType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReferenceType.Location = new System.Drawing.Point(96, 132);
            this.labReferenceType.Name = "labReferenceType";
            this.labReferenceType.Size = new System.Drawing.Size(47, 19);
            this.labReferenceType.TabIndex = 2;
            this.labReferenceType.Text = "標籤";
            // 
            // Frm_M15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labReferenceType);
            this.Controls.Add(this.btnReferenceType);
            this.Controls.Add(this.btnValueType);
            this.Name = "Frm_M15_CTS";
            this.Text = "Frm_M15_CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnReferenceType;
        private System.Windows.Forms.Label labReferenceType;
    }
}