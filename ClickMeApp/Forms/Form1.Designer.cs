﻿namespace ClickMeApp
{
    partial class Form1
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
            this.btn_ShowForm = new System.Windows.Forms.Button();
            this.txtB_Input = new System.Windows.Forms.TextBox();
            this.btn_Append = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ShowForm
            // 
            this.btn_ShowForm.Location = new System.Drawing.Point(296, 73);
            this.btn_ShowForm.Name = "btn_ShowForm";
            this.btn_ShowForm.Size = new System.Drawing.Size(175, 34);
            this.btn_ShowForm.TabIndex = 3;
            this.btn_ShowForm.Text = "Show Form";
            this.btn_ShowForm.UseVisualStyleBackColor = true;
            this.btn_ShowForm.Click += new System.EventHandler(this.btn_ShowForm_Click);
            // 
            // txtB_Input
            // 
            this.txtB_Input.Location = new System.Drawing.Point(267, 179);
            this.txtB_Input.Name = "txtB_Input";
            this.txtB_Input.Size = new System.Drawing.Size(250, 22);
            this.txtB_Input.TabIndex = 4;
            // 
            // btn_Append
            // 
            this.btn_Append.Location = new System.Drawing.Point(306, 259);
            this.btn_Append.Name = "btn_Append";
            this.btn_Append.Size = new System.Drawing.Size(175, 34);
            this.btn_Append.TabIndex = 5;
            this.btn_Append.Text = "Append";
            this.btn_Append.UseVisualStyleBackColor = true;
            this.btn_Append.Click += new System.EventHandler(this.btn_Append_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Append);
            this.Controls.Add(this.txtB_Input);
            this.Controls.Add(this.btn_ShowForm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ShowForm;
        private System.Windows.Forms.TextBox txtB_Input;
        private System.Windows.Forms.Button btn_Append;
    }
}

