namespace Recursivo_e_iterativo__Cálculo_de_Fibonacci
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            LstViewRecurcivo = new ListView();
            LsViewIterativo = new ListView();
            TextIterativo = new TextBox();
            TextRecurcive = new TextBox();
            BtnIterativo = new Button();
            BtnRecurcivo = new Button();
            LblTimeRecursivo = new Label();
            LblTimeIterativo = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 247);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 21;
            label2.Text = "Iterativo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 20;
            label1.Text = "Recurcivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 11);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 19;
            label4.Text = "Iterativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 11);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 18;
            label3.Text = "Recurcivo";
            // 
            // LstViewRecurcivo
            // 
            LstViewRecurcivo.Location = new Point(365, 29);
            LstViewRecurcivo.Name = "LstViewRecurcivo";
            LstViewRecurcivo.Size = new Size(183, 411);
            LstViewRecurcivo.TabIndex = 17;
            LstViewRecurcivo.UseCompatibleStateImageBehavior = false;
            // 
            // LsViewIterativo
            // 
            LsViewIterativo.Location = new Point(583, 29);
            LsViewIterativo.Name = "LsViewIterativo";
            LsViewIterativo.Size = new Size(179, 411);
            LsViewIterativo.TabIndex = 16;
            LsViewIterativo.UseCompatibleStateImageBehavior = false;
            // 
            // TextIterativo
            // 
            TextIterativo.Location = new Point(38, 265);
            TextIterativo.Name = "TextIterativo";
            TextIterativo.Size = new Size(218, 23);
            TextIterativo.TabIndex = 15;
            // 
            // TextRecurcive
            // 
            TextRecurcive.Location = new Point(38, 66);
            TextRecurcive.Name = "TextRecurcive";
            TextRecurcive.Size = new Size(218, 23);
            TextRecurcive.TabIndex = 14;
            // 
            // BtnIterativo
            // 
            BtnIterativo.Location = new Point(105, 294);
            BtnIterativo.Name = "BtnIterativo";
            BtnIterativo.Size = new Size(75, 23);
            BtnIterativo.TabIndex = 13;
            BtnIterativo.Text = "Insert";
            BtnIterativo.UseVisualStyleBackColor = true;
            BtnIterativo.Click += BtnIterativo_Click;
            // 
            // BtnRecurcivo
            // 
            BtnRecurcivo.Location = new Point(105, 95);
            BtnRecurcivo.Name = "BtnRecurcivo";
            BtnRecurcivo.Size = new Size(75, 23);
            BtnRecurcivo.TabIndex = 12;
            BtnRecurcivo.Text = "Insert";
            BtnRecurcivo.UseVisualStyleBackColor = true;
            BtnRecurcivo.Click += BtnRecurcivo_Click;
            // 
            // LblTimeRecursivo
            // 
            LblTimeRecursivo.AutoSize = true;
            LblTimeRecursivo.Location = new Point(117, 11);
            LblTimeRecursivo.Name = "LblTimeRecursivo";
            LblTimeRecursivo.Size = new Size(0, 15);
            LblTimeRecursivo.TabIndex = 22;
            // 
            // LblTimeIterativo
            // 
            LblTimeIterativo.AutoSize = true;
            LblTimeIterativo.Location = new Point(117, 211);
            LblTimeIterativo.Name = "LblTimeIterativo";
            LblTimeIterativo.Size = new Size(0, 15);
            LblTimeIterativo.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 211);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 24;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 11);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 25;
            label6.Text = "Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LblTimeIterativo);
            Controls.Add(LblTimeRecursivo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LstViewRecurcivo);
            Controls.Add(LsViewIterativo);
            Controls.Add(TextIterativo);
            Controls.Add(TextRecurcive);
            Controls.Add(BtnIterativo);
            Controls.Add(BtnRecurcivo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private ListView LstViewRecurcivo;
        private ListView LsViewIterativo;
        private TextBox TextIterativo;
        private TextBox TextRecurcive;
        private Button BtnIterativo;
        private Button BtnRecurcivo;
        private Label LblTimeRecursivo;
        private Label LblTimeIterativo;
        private Label label5;
        private Label label6;
    }
}
