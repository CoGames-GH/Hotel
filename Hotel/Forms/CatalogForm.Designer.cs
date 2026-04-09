using System;
using System.Windows.Forms;

namespace Hotel.Forms
{
    partial class CatalogForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dgv;
    private TextBox tbCity;
    private TextBox tbPrice;
    private DateTimePicker dtpFrom;
    private DateTimePicker dtpTo;
    private Button btnSearch;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.dgv = new DataGridView();
        this.tbCity = new TextBox();
        this.tbPrice = new TextBox();
        this.dtpFrom = new DateTimePicker();
        this.dtpTo = new DateTimePicker();
        this.btnSearch = new Button();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
        this.SuspendLayout();
        // 
        // dgv
        // 
        this.dgv.AllowUserToAddRows = false;
        this.dgv.AllowUserToDeleteRows = false;
        this.dgv.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
        | AnchorStyles.Left)
        | AnchorStyles.Right)));
        this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgv.Location = new System.Drawing.Point(12, 120);
        this.dgv.Name = "dgv";
        this.dgv.ReadOnly = true;
        this.dgv.Size = new System.Drawing.Size(760, 320);
        this.dgv.TabIndex = 0;
        // 
        // tbCity
        // 
        this.tbCity.Location = new System.Drawing.Point(60, 20);
        this.tbCity.Name = "tbCity";
        this.tbCity.Size = new System.Drawing.Size(120, 20);
        this.tbCity.TabIndex = 1;
        // 
        // tbPrice
        // 
        this.tbPrice.Location = new System.Drawing.Point(60, 50);
        this.tbPrice.Name = "tbPrice";
        this.tbPrice.Size = new System.Drawing.Size(120, 20);
        this.tbPrice.TabIndex = 2;
        // 
        // dtpFrom
        // 
        this.dtpFrom.Format = DateTimePickerFormat.Short;
        this.dtpFrom.Location = new System.Drawing.Point(280, 20);
        this.dtpFrom.Name = "dtpFrom";
        this.dtpFrom.Size = new System.Drawing.Size(120, 20);
        this.dtpFrom.TabIndex = 3;
        // 
        // dtpTo
        // 
        this.dtpTo.Format = DateTimePickerFormat.Short;
        this.dtpTo.Location = new System.Drawing.Point(280, 50);
        this.dtpTo.Name = "dtpTo";
        this.dtpTo.Size = new System.Drawing.Size(120, 20);
        this.dtpTo.TabIndex = 4;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new System.Drawing.Point(650, 20);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(90, 23);
        this.btnSearch.TabIndex = 5;
        this.btnSearch.Text = "Найти";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 23);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(37, 13);
        this.label1.TabIndex = 6;
        this.label1.Text = "Город";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 53);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(33, 13);
        this.label2.TabIndex = 7;
        this.label2.Text = "Цена";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(220, 23);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(54, 13);
        this.label3.TabIndex = 8;
        this.label3.Text = "Заезд от";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(220, 53);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(54, 13);
        this.label4.TabIndex = 9;
        this.label4.Text = "Выезд до";
        // 
        // CatalogForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 461);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.dtpTo);
        this.Controls.Add(this.dtpFrom);
        this.Controls.Add(this.tbPrice);
        this.Controls.Add(this.tbCity);
        this.Controls.Add(this.dgv);
        this.Name = "CatalogForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Каталог номеров";
        ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
}