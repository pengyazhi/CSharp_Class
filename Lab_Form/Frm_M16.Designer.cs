namespace Lab_Form
{
    partial class Frm_M16
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
            this.btnPassByValueType = new System.Windows.Forms.Button();
            this.btnPassByReferenceType = new System.Windows.Forms.Button();
            this.btnByRef = new System.Windows.Forms.Button();
            this.btnPassByOut = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPassByValueType
            // 
            this.btnPassByValueType.Location = new System.Drawing.Point(88, 55);
            this.btnPassByValueType.Name = "btnPassByValueType";
            this.btnPassByValueType.Size = new System.Drawing.Size(187, 91);
            this.btnPassByValueType.TabIndex = 0;
            this.btnPassByValueType.Text = "Pass by Value Type";
            this.btnPassByValueType.UseVisualStyleBackColor = true;
            this.btnPassByValueType.Click += new System.EventHandler(this.btnPassbyValueType_Click);
            // 
            // btnPassByReferenceType
            // 
            this.btnPassByReferenceType.Location = new System.Drawing.Point(88, 197);
            this.btnPassByReferenceType.Name = "btnPassByReferenceType";
            this.btnPassByReferenceType.Size = new System.Drawing.Size(187, 91);
            this.btnPassByReferenceType.TabIndex = 1;
            this.btnPassByReferenceType.Text = "Pass by Reference Type";
            this.btnPassByReferenceType.UseVisualStyleBackColor = true;
            this.btnPassByReferenceType.Click += new System.EventHandler(this.btnPassByReferenceType_Click);
            // 
            // btnByRef
            // 
            this.btnByRef.Location = new System.Drawing.Point(88, 332);
            this.btnByRef.Name = "btnByRef";
            this.btnByRef.Size = new System.Drawing.Size(187, 91);
            this.btnByRef.TabIndex = 2;
            this.btnByRef.Text = "Pass by Ref";
            this.btnByRef.UseVisualStyleBackColor = true;
            this.btnByRef.Click += new System.EventHandler(this.btnByRef_Click);
            // 
            // btnPassByOut
            // 
            this.btnPassByOut.Location = new System.Drawing.Point(326, 55);
            this.btnPassByOut.Name = "btnPassByOut";
            this.btnPassByOut.Size = new System.Drawing.Size(187, 91);
            this.btnPassByOut.TabIndex = 3;
            this.btnPassByOut.Text = "Pass by Out";
            this.btnPassByOut.UseVisualStyleBackColor = true;
            this.btnPassByOut.Click += new System.EventHandler(this.btnPassByOut_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(326, 197);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(187, 91);
            this.btnParams.TabIndex = 4;
            this.btnParams.Text = "Params";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // Frm_M16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnPassByOut);
            this.Controls.Add(this.btnByRef);
            this.Controls.Add(this.btnPassByReferenceType);
            this.Controls.Add(this.btnPassByValueType);
            this.Name = "Frm_M16";
            this.Text = "Frm_M16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassByValueType;
        private System.Windows.Forms.Button btnPassByReferenceType;
        private System.Windows.Forms.Button btnByRef;
        private System.Windows.Forms.Button btnPassByOut;
        private System.Windows.Forms.Button btnParams;
    }
}