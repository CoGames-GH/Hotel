using System;
using System.Windows.Forms;

namespace Hotel.Forms
{
    partial class ApprovalForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgv;
        private Button btnApprove;
        private Button btnReject;
        private TextBox tbComment;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgv = new DataGridView();
            this.btnApprove = new Button();
            this.btnReject = new Button();
            this.tbComment = new TextBox();
            this.label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(760, 300);
            this.dgv.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.btnApprove.Location = new System.Drawing.Point(12, 420);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(120, 30);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Утвердить";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.btnReject.Location = new System.Drawing.Point(150, 420);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(120, 30);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Отклонить";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right)));
            this.tbComment.Location = new System.Drawing.Point(12, 380);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(760, 20);
            this.tbComment.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Комментарий:";
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgv);
            this.Name = "ApprovalForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Согласование заявок";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}