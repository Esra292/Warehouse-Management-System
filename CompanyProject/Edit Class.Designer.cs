
namespace CompanyProject
{
    partial class Edit_Class
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
            this.Class_Edit_Ok = new System.Windows.Forms.Button();
            this.Class_Edit_Cancel = new System.Windows.Forms.Button();
            this.Class_Edit_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Class_Edit_Ok
            // 
            this.Class_Edit_Ok.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Class_Edit_Ok.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Edit_Ok.ForeColor = System.Drawing.Color.Snow;
            this.Class_Edit_Ok.Location = new System.Drawing.Point(62, 95);
            this.Class_Edit_Ok.Name = "Class_Edit_Ok";
            this.Class_Edit_Ok.Size = new System.Drawing.Size(75, 32);
            this.Class_Edit_Ok.TabIndex = 0;
            this.Class_Edit_Ok.Text = "Ok";
            this.Class_Edit_Ok.UseVisualStyleBackColor = false;
            this.Class_Edit_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Class_Edit_Cancel
            // 
            this.Class_Edit_Cancel.BackColor = System.Drawing.Color.Firebrick;
            this.Class_Edit_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Class_Edit_Cancel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Edit_Cancel.ForeColor = System.Drawing.Color.Snow;
            this.Class_Edit_Cancel.Location = new System.Drawing.Point(165, 95);
            this.Class_Edit_Cancel.Name = "Class_Edit_Cancel";
            this.Class_Edit_Cancel.Size = new System.Drawing.Size(75, 32);
            this.Class_Edit_Cancel.TabIndex = 1;
            this.Class_Edit_Cancel.Text = "Cancel";
            this.Class_Edit_Cancel.UseVisualStyleBackColor = false;
            // 
            // Class_Edit_Label
            // 
            this.Class_Edit_Label.AutoSize = true;
            this.Class_Edit_Label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Edit_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.Class_Edit_Label.Location = new System.Drawing.Point(16, 38);
            this.Class_Edit_Label.Name = "Class_Edit_Label";
            this.Class_Edit_Label.Size = new System.Drawing.Size(257, 18);
            this.Class_Edit_Label.TabIndex = 2;
            this.Class_Edit_Label.Text = "Do you want to edit this class?";
            // 
            // Edit_Class
            // 
            this.AcceptButton = this.Class_Edit_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.Class_Edit_Cancel;
            this.ClientSize = new System.Drawing.Size(295, 176);
            this.Controls.Add(this.Class_Edit_Label);
            this.Controls.Add(this.Class_Edit_Cancel);
            this.Controls.Add(this.Class_Edit_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Class_Edit_Ok;
        private System.Windows.Forms.Button Class_Edit_Cancel;
        private System.Windows.Forms.Label Class_Edit_Label;
    }
}