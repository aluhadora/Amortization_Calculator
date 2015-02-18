namespace Amoritization_Calc
{
  partial class AmortizationForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmortizationForm));
      this.principalTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.interestTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.paymentTextBox = new System.Windows.Forms.TextBox();
      this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
      this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.interestLabel = new System.Windows.Forms.Label();
      this.yearsLabel = new System.Windows.Forms.Label();
      this.monthsLabel = new System.Windows.Forms.Label();
      this.graphButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // principalTextBox
      // 
      this.principalTextBox.Location = new System.Drawing.Point(68, 15);
      this.principalTextBox.Name = "principalTextBox";
      this.principalTextBox.Size = new System.Drawing.Size(100, 20);
      this.principalTextBox.TabIndex = 0;
      this.principalTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Principal:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Interest:";
      // 
      // interestTextBox
      // 
      this.interestTextBox.Location = new System.Drawing.Point(68, 41);
      this.interestTextBox.Name = "interestTextBox";
      this.interestTextBox.Size = new System.Drawing.Size(43, 20);
      this.interestTextBox.TabIndex = 2;
      this.interestTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 70);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Payment:";
      // 
      // paymentTextBox
      // 
      this.paymentTextBox.Location = new System.Drawing.Point(68, 67);
      this.paymentTextBox.Name = "paymentTextBox";
      this.paymentTextBox.Size = new System.Drawing.Size(54, 20);
      this.paymentTextBox.TabIndex = 4;
      this.paymentTextBox.TextChanged += new System.EventHandler(this.ValueChanged);
      // 
      // shapeContainer1
      // 
      this.shapeContainer1.Location = new System.Drawing.Point(12, 12);
      this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
      this.shapeContainer1.Name = "shapeContainer1";
      this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
      this.shapeContainer1.Size = new System.Drawing.Size(260, 237);
      this.shapeContainer1.TabIndex = 6;
      this.shapeContainer1.TabStop = false;
      // 
      // lineShape1
      // 
      this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lineShape1.Name = "lineShape1";
      this.lineShape1.X1 = 5;
      this.lineShape1.X2 = 255;
      this.lineShape1.Y1 = 91;
      this.lineShape1.Y2 = 91;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label4.Location = new System.Drawing.Point(12, 122);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Months:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label5.Location = new System.Drawing.Point(12, 138);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(37, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Years:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label6.Location = new System.Drawing.Point(12, 154);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 13);
      this.label6.TabIndex = 9;
      this.label6.Text = "Extra interest:";
      // 
      // interestLabel
      // 
      this.interestLabel.AutoSize = true;
      this.interestLabel.Location = new System.Drawing.Point(89, 154);
      this.interestLabel.Name = "interestLabel";
      this.interestLabel.Size = new System.Drawing.Size(67, 13);
      this.interestLabel.TabIndex = 12;
      this.interestLabel.Text = "$999,999.00";
      // 
      // yearsLabel
      // 
      this.yearsLabel.AutoSize = true;
      this.yearsLabel.Location = new System.Drawing.Point(89, 138);
      this.yearsLabel.Name = "yearsLabel";
      this.yearsLabel.Size = new System.Drawing.Size(46, 13);
      this.yearsLabel.TabIndex = 11;
      this.yearsLabel.Text = "999,999";
      // 
      // monthsLabel
      // 
      this.monthsLabel.AutoSize = true;
      this.monthsLabel.Location = new System.Drawing.Point(89, 122);
      this.monthsLabel.Name = "monthsLabel";
      this.monthsLabel.Size = new System.Drawing.Size(46, 13);
      this.monthsLabel.TabIndex = 10;
      this.monthsLabel.Text = "999,999";
      // 
      // graphButton
      // 
      this.graphButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.graphButton.Location = new System.Drawing.Point(193, 65);
      this.graphButton.Name = "graphButton";
      this.graphButton.Size = new System.Drawing.Size(75, 23);
      this.graphButton.TabIndex = 13;
      this.graphButton.Text = "Graph...";
      this.graphButton.UseVisualStyleBackColor = true;
      this.graphButton.Click += new System.EventHandler(this.GraphButtonClick);
      // 
      // AmortizationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.graphButton);
      this.Controls.Add(this.interestLabel);
      this.Controls.Add(this.yearsLabel);
      this.Controls.Add(this.monthsLabel);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.paymentTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.interestTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.principalTextBox);
      this.Controls.Add(this.shapeContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "AmortizationForm";
      this.Padding = new System.Windows.Forms.Padding(12);
      this.Text = "Amoritization";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox principalTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox interestTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox paymentTextBox;
    private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label interestLabel;
    private System.Windows.Forms.Label yearsLabel;
    private System.Windows.Forms.Label monthsLabel;
    private System.Windows.Forms.Button graphButton;
  }
}

