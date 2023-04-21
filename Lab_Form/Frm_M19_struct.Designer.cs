namespace Lab_Form
{
    partial class Frm_M19_struct
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
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.labEmpolyeeAge = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labEmpolyeeList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeName.Location = new System.Drawing.Point(68, 40);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(117, 27);
            this.labEmployeeName.TabIndex = 0;
            this.labEmployeeName.Text = "員工姓名：";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(191, 37);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(137, 35);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(191, 90);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(137, 35);
            this.txtEmployeeAge.TabIndex = 3;
            // 
            // labEmpolyeeAge
            // 
            this.labEmpolyeeAge.AutoSize = true;
            this.labEmpolyeeAge.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmpolyeeAge.Location = new System.Drawing.Point(68, 93);
            this.labEmpolyeeAge.Name = "labEmpolyeeAge";
            this.labEmpolyeeAge.Size = new System.Drawing.Size(117, 27);
            this.labEmpolyeeAge.TabIndex = 2;
            this.labEmpolyeeAge.Text = "員工年齡：";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(150, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 61);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labEmpolyeeList
            // 
            this.labEmpolyeeList.AutoSize = true;
            this.labEmpolyeeList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labEmpolyeeList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmpolyeeList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labEmpolyeeList.Location = new System.Drawing.Point(393, 37);
            this.labEmpolyeeList.Name = "labEmpolyeeList";
            this.labEmpolyeeList.Size = new System.Drawing.Size(117, 26);
            this.labEmpolyeeList.TabIndex = 5;
            this.labEmpolyeeList.Text = "員工列表：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(393, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "員工總數,平均年齡";
            // 
            // Frm_M19_struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labEmpolyeeList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.labEmpolyeeAge);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.labEmployeeName);
            this.Name = "Frm_M19_struct";
            this.Text = "Frm_M19_struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label labEmpolyeeAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labEmpolyeeList;
        private System.Windows.Forms.Label label1;
    }
}