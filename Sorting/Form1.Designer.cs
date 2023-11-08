namespace Sorting
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
            if(disposing && (components != null))
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
            inputTB = new TextBox();
            genNUD = new NumericUpDown();
            inputCB = new CheckBox();
            bsB = new Button();
            ssB = new Button();
            isB = new Button();
            msB = new Button();
            qsB = new Button();
            outputL = new Label();
            timeL = new Label();
            timeValL = new Label();
            ((System.ComponentModel.ISupportInitialize)genNUD).BeginInit();
            SuspendLayout();
            // 
            // inputTB
            // 
            inputTB.Location = new Point(6, 6);
            inputTB.Margin = new Padding(2, 1, 2, 1);
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(176, 23);
            inputTB.TabIndex = 0;
            // 
            // genNUD
            // 
            genNUD.Enabled = false;
            genNUD.Location = new Point(295, 6);
            genNUD.Margin = new Padding(2, 1, 2, 1);
            genNUD.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            genNUD.Name = "genNUD";
            genNUD.Size = new Size(129, 23);
            genNUD.TabIndex = 1;
            // 
            // inputCB
            // 
            inputCB.AutoSize = true;
            inputCB.Checked = true;
            inputCB.CheckState = CheckState.Checked;
            inputCB.Location = new Point(184, 6);
            inputCB.Margin = new Padding(2, 1, 2, 1);
            inputCB.Name = "inputCB";
            inputCB.Size = new Size(101, 19);
            inputCB.TabIndex = 2;
            inputCB.Text = "Use user input";
            inputCB.UseVisualStyleBackColor = true;
            inputCB.CheckedChanged += inputCB_CheckedChanged;
            // 
            // bsB
            // 
            bsB.Location = new Point(6, 184);
            bsB.Margin = new Padding(2, 1, 2, 1);
            bsB.Name = "bsB";
            bsB.Size = new Size(81, 22);
            bsB.TabIndex = 4;
            bsB.Text = "BS";
            bsB.UseVisualStyleBackColor = true;
            bsB.Click += bsB_Click;
            // 
            // ssB
            // 
            ssB.Location = new Point(90, 184);
            ssB.Margin = new Padding(2, 1, 2, 1);
            ssB.Name = "ssB";
            ssB.Size = new Size(81, 22);
            ssB.TabIndex = 5;
            ssB.Text = "SS";
            ssB.UseVisualStyleBackColor = true;
            ssB.Click += ssB_Click;
            // 
            // isB
            // 
            isB.Location = new Point(174, 184);
            isB.Margin = new Padding(2, 1, 2, 1);
            isB.Name = "isB";
            isB.Size = new Size(81, 22);
            isB.TabIndex = 6;
            isB.Text = "IS";
            isB.UseVisualStyleBackColor = true;
            isB.Click += isB_Click;
            // 
            // msB
            // 
            msB.Location = new Point(258, 184);
            msB.Margin = new Padding(2, 1, 2, 1);
            msB.Name = "msB";
            msB.Size = new Size(81, 22);
            msB.TabIndex = 7;
            msB.Text = "MS";
            msB.UseVisualStyleBackColor = true;
            msB.Click += msB_Click;
            // 
            // qsB
            // 
            qsB.Location = new Point(342, 184);
            qsB.Margin = new Padding(2, 1, 2, 1);
            qsB.Name = "qsB";
            qsB.Size = new Size(81, 22);
            qsB.TabIndex = 8;
            qsB.Text = "QS";
            qsB.UseVisualStyleBackColor = true;
            qsB.Click += qsB_Click;
            // 
            // outputL
            // 
            outputL.AutoSize = true;
            outputL.Location = new Point(6, 25);
            outputL.Margin = new Padding(2, 0, 2, 0);
            outputL.Name = "outputL";
            outputL.Size = new Size(0, 15);
            outputL.TabIndex = 9;
            // 
            // timeL
            // 
            timeL.AutoSize = true;
            timeL.Location = new Point(6, 167);
            timeL.Margin = new Padding(2, 0, 2, 0);
            timeL.Name = "timeL";
            timeL.Size = new Size(36, 15);
            timeL.TabIndex = 10;
            timeL.Text = "Time:";
            // 
            // timeValL
            // 
            timeValL.AutoSize = true;
            timeValL.Location = new Point(46, 167);
            timeValL.Margin = new Padding(2, 0, 2, 0);
            timeValL.Name = "timeValL";
            timeValL.Size = new Size(0, 15);
            timeValL.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(timeValL);
            Controls.Add(timeL);
            Controls.Add(outputL);
            Controls.Add(qsB);
            Controls.Add(msB);
            Controls.Add(isB);
            Controls.Add(ssB);
            Controls.Add(bsB);
            Controls.Add(inputCB);
            Controls.Add(genNUD);
            Controls.Add(inputTB);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)genNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTB;
        private NumericUpDown genNUD;
        private CheckBox inputCB;
        private Button bsB;
        private Button ssB;
        private Button isB;
        private Button msB;
        private Button qsB;
        private Label outputL;
        private Label timeL;
        private Label timeValL;
    }
}