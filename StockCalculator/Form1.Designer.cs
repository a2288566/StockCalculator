namespace StockCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unittextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buypricetextBox = new System.Windows.Forms.TextBox();
            this.buyplusbutton = new System.Windows.Forms.Button();
            this.buysubtractbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sellpricetextBox = new System.Windows.Forms.TextBox();
            this.sellplusbutton = new System.Windows.Forms.Button();
            this.sellsubtractbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buychargetextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sellchargetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buypricelabel = new System.Windows.Forms.Label();
            this.sellchargelabel = new System.Windows.Forms.Label();
            this.buydiscountlabel = new System.Windows.Forms.Label();
            this.selldiscountlabel = new System.Windows.Forms.Label();
            this.tradetaxlabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.IncomeStatementlabel = new System.Windows.Forms.Label();
            this.percentlabel = new System.Windows.Forms.Label();
            this.buychargelabel = new System.Windows.Forms.Label();
            this.sellpricelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unittextBox
            // 
            this.unittextBox.Location = new System.Drawing.Point(46, 50);
            this.unittextBox.Name = "unittextBox";
            this.unittextBox.Size = new System.Drawing.Size(79, 23);
            this.unittextBox.TabIndex = 2;
            this.unittextBox.TextChanged += new System.EventHandler(this.unittextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "股";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "買入價:";
            // 
            // buypricetextBox
            // 
            this.buypricetextBox.Location = new System.Drawing.Point(113, 103);
            this.buypricetextBox.Name = "buypricetextBox";
            this.buypricetextBox.Size = new System.Drawing.Size(89, 23);
            this.buypricetextBox.TabIndex = 5;
            this.buypricetextBox.TextChanged += new System.EventHandler(this.buypricetextBox_TextChanged);
            // 
            // buyplusbutton
            // 
            this.buyplusbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyplusbutton.Location = new System.Drawing.Point(219, 103);
            this.buyplusbutton.Name = "buyplusbutton";
            this.buyplusbutton.Size = new System.Drawing.Size(38, 23);
            this.buyplusbutton.TabIndex = 6;
            this.buyplusbutton.Text = "+";
            this.buyplusbutton.UseVisualStyleBackColor = true;
            this.buyplusbutton.Click += new System.EventHandler(this.buyplusbutton_Click);
            // 
            // buysubtractbutton
            // 
            this.buysubtractbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buysubtractbutton.Location = new System.Drawing.Point(263, 103);
            this.buysubtractbutton.Name = "buysubtractbutton";
            this.buysubtractbutton.Size = new System.Drawing.Size(38, 23);
            this.buysubtractbutton.TabIndex = 7;
            this.buysubtractbutton.Text = "-";
            this.buysubtractbutton.UseVisualStyleBackColor = true;
            this.buysubtractbutton.Click += new System.EventHandler(this.buysubtractbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(341, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "賣出價:";
            // 
            // sellpricetextBox
            // 
            this.sellpricetextBox.Location = new System.Drawing.Point(408, 103);
            this.sellpricetextBox.Name = "sellpricetextBox";
            this.sellpricetextBox.Size = new System.Drawing.Size(89, 23);
            this.sellpricetextBox.TabIndex = 5;
            this.sellpricetextBox.TextChanged += new System.EventHandler(this.sellpricetextBox_TextChanged);
            // 
            // sellplusbutton
            // 
            this.sellplusbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellplusbutton.Location = new System.Drawing.Point(514, 103);
            this.sellplusbutton.Name = "sellplusbutton";
            this.sellplusbutton.Size = new System.Drawing.Size(38, 23);
            this.sellplusbutton.TabIndex = 6;
            this.sellplusbutton.Text = "+";
            this.sellplusbutton.UseVisualStyleBackColor = true;
            this.sellplusbutton.Click += new System.EventHandler(this.sellplusbutton_Click);
            // 
            // sellsubtractbutton
            // 
            this.sellsubtractbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellsubtractbutton.Location = new System.Drawing.Point(558, 103);
            this.sellsubtractbutton.Name = "sellsubtractbutton";
            this.sellsubtractbutton.Size = new System.Drawing.Size(38, 23);
            this.sellsubtractbutton.TabIndex = 7;
            this.sellsubtractbutton.Text = "-";
            this.sellsubtractbutton.UseVisualStyleBackColor = true;
            this.sellsubtractbutton.Click += new System.EventHandler(this.sellsubtractbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "手續費";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "手續費折扣";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(341, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "手續費";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(341, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "證券交易稅";
            // 
            // buychargetextBox
            // 
            this.buychargetextBox.Location = new System.Drawing.Point(206, 201);
            this.buychargetextBox.Name = "buychargetextBox";
            this.buychargetextBox.Size = new System.Drawing.Size(64, 23);
            this.buychargetextBox.TabIndex = 5;
            this.buychargetextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(276, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "折";
            // 
            // sellchargetextBox
            // 
            this.sellchargetextBox.Location = new System.Drawing.Point(501, 201);
            this.sellchargetextBox.Name = "sellchargetextBox";
            this.sellchargetextBox.Size = new System.Drawing.Size(64, 23);
            this.sellchargetextBox.TabIndex = 5;
            this.sellchargetextBox.TextChanged += new System.EventHandler(this.sellchargetextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(571, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "折";
            // 
            // buypricelabel
            // 
            this.buypricelabel.AutoSize = true;
            this.buypricelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buypricelabel.Location = new System.Drawing.Point(219, 371);
            this.buypricelabel.Name = "buypricelabel";
            this.buypricelabel.Size = new System.Drawing.Size(0, 20);
            this.buypricelabel.TabIndex = 8;
            // 
            // sellchargelabel
            // 
            this.sellchargelabel.AutoSize = true;
            this.sellchargelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellchargelabel.Location = new System.Drawing.Point(534, 166);
            this.sellchargelabel.Name = "sellchargelabel";
            this.sellchargelabel.Size = new System.Drawing.Size(0, 20);
            this.sellchargelabel.TabIndex = 8;
            this.sellchargelabel.Click += new System.EventHandler(this.sellChargelabel_Click);
            // 
            // buydiscountlabel
            // 
            this.buydiscountlabel.AutoSize = true;
            this.buydiscountlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buydiscountlabel.Location = new System.Drawing.Point(239, 240);
            this.buydiscountlabel.Name = "buydiscountlabel";
            this.buydiscountlabel.Size = new System.Drawing.Size(0, 20);
            this.buydiscountlabel.TabIndex = 8;
            // 
            // selldiscountlabel
            // 
            this.selldiscountlabel.AutoSize = true;
            this.selldiscountlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selldiscountlabel.Location = new System.Drawing.Point(534, 240);
            this.selldiscountlabel.Name = "selldiscountlabel";
            this.selldiscountlabel.Size = new System.Drawing.Size(0, 20);
            this.selldiscountlabel.TabIndex = 8;
            // 
            // tradetaxlabel
            // 
            this.tradetaxlabel.AutoSize = true;
            this.tradetaxlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tradetaxlabel.Location = new System.Drawing.Point(534, 284);
            this.tradetaxlabel.Name = "tradetaxlabel";
            this.tradetaxlabel.Size = new System.Drawing.Size(0, 20);
            this.tradetaxlabel.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(341, 325);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "現股當沖";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(46, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "買入金額:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(341, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "賣出所得:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(341, 409);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "利潤/虧損";
            // 
            // IncomeStatementlabel
            // 
            this.IncomeStatementlabel.AutoSize = true;
            this.IncomeStatementlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeStatementlabel.Location = new System.Drawing.Point(534, 410);
            this.IncomeStatementlabel.Name = "IncomeStatementlabel";
            this.IncomeStatementlabel.Size = new System.Drawing.Size(0, 20);
            this.IncomeStatementlabel.TabIndex = 8;
            // 
            // percentlabel
            // 
            this.percentlabel.AutoSize = true;
            this.percentlabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentlabel.Location = new System.Drawing.Point(534, 443);
            this.percentlabel.Name = "percentlabel";
            this.percentlabel.Size = new System.Drawing.Size(0, 20);
            this.percentlabel.TabIndex = 8;
            // 
            // buychargelabel
            // 
            this.buychargelabel.AutoSize = true;
            this.buychargelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buychargelabel.Location = new System.Drawing.Point(239, 166);
            this.buychargelabel.Name = "buychargelabel";
            this.buychargelabel.Size = new System.Drawing.Size(0, 20);
            this.buychargelabel.TabIndex = 8;
            this.buychargelabel.Click += new System.EventHandler(this.buyChargelabel_Click);
            // 
            // sellpricelabel
            // 
            this.sellpricelabel.AutoSize = true;
            this.sellpricelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellpricelabel.Location = new System.Drawing.Point(534, 372);
            this.sellpricelabel.Name = "sellpricelabel";
            this.sellpricelabel.Size = new System.Drawing.Size(0, 20);
            this.sellpricelabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 514);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selldiscountlabel);
            this.Controls.Add(this.buydiscountlabel);
            this.Controls.Add(this.tradetaxlabel);
            this.Controls.Add(this.buychargelabel);
            this.Controls.Add(this.sellchargelabel);
            this.Controls.Add(this.percentlabel);
            this.Controls.Add(this.IncomeStatementlabel);
            this.Controls.Add(this.sellpricelabel);
            this.Controls.Add(this.buypricelabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellsubtractbutton);
            this.Controls.Add(this.buysubtractbutton);
            this.Controls.Add(this.sellplusbutton);
            this.Controls.Add(this.buyplusbutton);
            this.Controls.Add(this.sellpricetextBox);
            this.Controls.Add(this.sellchargetextBox);
            this.Controls.Add(this.buychargetextBox);
            this.Controls.Add(this.buypricetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unittextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox unittextBox;
        private Label label1;
        private Label label2;
        private TextBox buypricetextBox;
        private Button buyplusbutton;
        private Button buysubtractbutton;
        private Label label3;
        private TextBox sellpricetextBox;
        private Button sellplusbutton;
        private Button sellsubtractbutton;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox buychargetextBox;
        private Label label8;
        private TextBox sellchargetextBox;
        private Label label9;
        private Label buypricelabel;
        private Label sellchargelabel;
        private Label buydiscountlabel;
        private Label selldiscountlabel;
        private Label tradetaxlabel;
        private CheckBox checkBox1;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label IncomeStatementlabel;
        private Label percentlabel;
        private Label buychargelabel;
        private Label sellpricelabel;
    }
}