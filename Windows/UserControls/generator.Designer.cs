namespace Random_Numbers_Generator
{
    partial class generator
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resultRTB = new System.Windows.Forms.RichTextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.informCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.howManyTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signTB = new System.Windows.Forms.TextBox();
            this.generateLabel = new System.Windows.Forms.Label();
            this.generateTimer = new System.Windows.Forms.Timer(this.components);
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // resultRTB
            // 
            this.resultRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultRTB.Location = new System.Drawing.Point(268, 4);
            this.resultRTB.Name = "resultRTB";
            this.resultRTB.ReadOnly = true;
            this.resultRTB.Size = new System.Drawing.Size(329, 325);
            this.resultRTB.TabIndex = 0;
            this.resultRTB.Text = "";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(268, 355);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 40);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(382, 355);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 40);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(497, 355);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.ForeColor = System.Drawing.Color.Black;
            this.generateButton.Location = new System.Drawing.Point(67, 309);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(141, 40);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // informCB
            // 
            this.informCB.AutoSize = true;
            this.informCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informCB.Location = new System.Drawing.Point(17, 364);
            this.informCB.Name = "informCB";
            this.informCB.Size = new System.Drawing.Size(236, 24);
            this.informCB.TabIndex = 5;
            this.informCB.Text = "Inform me after generate end";
            this.informCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "From number";
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromTB.Location = new System.Drawing.Point(62, 31);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(160, 26);
            this.fromTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(92, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "To number";
            // 
            // toTB
            // 
            this.toTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toTB.Location = new System.Drawing.Point(62, 87);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(160, 26);
            this.toTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(54, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "How many numbers";
            // 
            // howManyTB
            // 
            this.howManyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howManyTB.Location = new System.Drawing.Point(62, 143);
            this.howManyTB.Name = "howManyTB";
            this.howManyTB.Size = new System.Drawing.Size(160, 26);
            this.howManyTB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Interval between generating";
            // 
            // intervalTB
            // 
            this.intervalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intervalTB.Location = new System.Drawing.Point(62, 199);
            this.intervalTB.Name = "intervalTB";
            this.intervalTB.Size = new System.Drawing.Size(160, 26);
            this.intervalTB.TabIndex = 17;
            this.intervalTB.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sign between numbers";
            // 
            // signTB
            // 
            this.signTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signTB.Location = new System.Drawing.Point(62, 255);
            this.signTB.Name = "signTB";
            this.signTB.Size = new System.Drawing.Size(160, 26);
            this.signTB.TabIndex = 19;
            // 
            // generateLabel
            // 
            this.generateLabel.AutoSize = true;
            this.generateLabel.Location = new System.Drawing.Point(268, 335);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(114, 13);
            this.generateLabel.TabIndex = 20;
            this.generateLabel.Text = "Wygenerowano:  0 / 0";
            // 
            // generateTimer
            // 
            this.generateTimer.Interval = 10;
            this.generateTimer.Tick += new System.EventHandler(this.generateTimer_Tick);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "\"Text files (*.txt)|*.txt\"";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.generateLabel);
            this.Controls.Add(this.signTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.intervalTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.howManyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.informCB);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resultRTB);
            this.Name = "generator";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultRTB;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox informCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox howManyTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intervalTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signTB;
        private System.Windows.Forms.Label generateLabel;
        private System.Windows.Forms.Timer generateTimer;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}
