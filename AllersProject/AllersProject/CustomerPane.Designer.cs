﻿namespace AllersProject
{
    partial class CustomerPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPane));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.advancedFlowLayoutPanel1 = new MakarovDev.ExpandCollapsePanel.AdvancedFlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.combQuantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Buscar cliente por codigo";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soporte Minimo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confianza Minima";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(468, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // advancedFlowLayoutPanel1
            // 
            this.advancedFlowLayoutPanel1.AutoScroll = true;
            this.advancedFlowLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.advancedFlowLayoutPanel1.Name = "advancedFlowLayoutPanel1";
            this.advancedFlowLayoutPanel1.Size = new System.Drawing.Size(768, 532);
            this.advancedFlowLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rango de clientes";
            // 
            // combQuantity
            // 
            this.combQuantity.FormattingEnabled = true;
            this.combQuantity.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15"});
            this.combQuantity.Location = new System.Drawing.Point(678, 12);
            this.combQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.combQuantity.Name = "combQuantity";
            this.combQuantity.Size = new System.Drawing.Size(68, 21);
            this.combQuantity.TabIndex = 0;
            this.combQuantity.Text = "0";
            this.combQuantity.SelectedIndexChanged += new System.EventHandler(this.combQuantity_SelectedIndexChanged);
            // 
            // CustomerPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.combQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.advancedFlowLayoutPanel1);
            this.Name = "CustomerPane";
            this.Size = new System.Drawing.Size(774, 557);
            this.Load += new System.EventHandler(this.CustomerPane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MakarovDev.ExpandCollapsePanel.AdvancedFlowLayoutPanel advancedFlowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combQuantity;
    }
}
