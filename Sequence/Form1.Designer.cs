namespace Sequence
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
            this.enterSequenceTextBox = new System.Windows.Forms.TextBox();
            this.inputSequenceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.getResultButton = new System.Windows.Forms.Button();
            this.enterU0370Button = new System.Windows.Forms.Button();
            this.enterU02C4Button = new System.Windows.Forms.Button();
            this.enterU02C5Button = new System.Windows.Forms.Button();
            this.enterU00ACButton = new System.Windows.Forms.Button();
            this.enterU2192Button = new System.Windows.Forms.Button();
            this.sequenceValidationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterSequenceTextBox
            // 
            this.enterSequenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterSequenceTextBox.Location = new System.Drawing.Point(23, 42);
            this.enterSequenceTextBox.Name = "enterSequenceTextBox";
            this.enterSequenceTextBox.Size = new System.Drawing.Size(401, 39);
            this.enterSequenceTextBox.TabIndex = 0;
            this.enterSequenceTextBox.TextChanged += new System.EventHandler(this.enterSequenceTextBox_TextChanged);
            // 
            // inputSequenceLabel
            // 
            this.inputSequenceLabel.AutoSize = true;
            this.inputSequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSequenceLabel.Location = new System.Drawing.Point(23, 13);
            this.inputSequenceLabel.Name = "inputSequenceLabel";
            this.inputSequenceLabel.Size = new System.Drawing.Size(197, 25);
            this.inputSequenceLabel.TabIndex = 1;
            this.inputSequenceLabel.Text = "Введите секвенцию";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(23, 88);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(111, 25);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(23, 128);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(401, 283);
            this.resultTextBox.TabIndex = 3;
            // 
            // getResultButton
            // 
            this.getResultButton.Enabled = false;
            this.getResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getResultButton.Location = new System.Drawing.Point(512, 44);
            this.getResultButton.Name = "getResultButton";
            this.getResultButton.Size = new System.Drawing.Size(193, 64);
            this.getResultButton.TabIndex = 4;
            this.getResultButton.Text = "Получить";
            this.getResultButton.UseVisualStyleBackColor = true;
            this.getResultButton.Click += new System.EventHandler(this.getResultButton_Click);
            // 
            // enterU0370Button
            // 
            this.enterU0370Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterU0370Button.Location = new System.Drawing.Point(512, 165);
            this.enterU0370Button.Name = "enterU0370Button";
            this.enterU0370Button.Size = new System.Drawing.Size(70, 70);
            this.enterU0370Button.TabIndex = 5;
            this.enterU0370Button.Text = "Ͱ";
            this.enterU0370Button.UseVisualStyleBackColor = true;
            this.enterU0370Button.Click += new System.EventHandler(this.enterU0370Button_Click);
            // 
            // enterU02C4Button
            // 
            this.enterU02C4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterU02C4Button.Location = new System.Drawing.Point(598, 165);
            this.enterU02C4Button.Name = "enterU02C4Button";
            this.enterU02C4Button.Size = new System.Drawing.Size(70, 70);
            this.enterU02C4Button.TabIndex = 6;
            this.enterU02C4Button.Text = "˄";
            this.enterU02C4Button.UseVisualStyleBackColor = true;
            this.enterU02C4Button.Click += new System.EventHandler(this.enterU02C4Button_Click);
            // 
            // enterU02C5Button
            // 
            this.enterU02C5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterU02C5Button.Location = new System.Drawing.Point(512, 254);
            this.enterU02C5Button.Name = "enterU02C5Button";
            this.enterU02C5Button.Size = new System.Drawing.Size(70, 70);
            this.enterU02C5Button.TabIndex = 7;
            this.enterU02C5Button.Text = "˅";
            this.enterU02C5Button.UseVisualStyleBackColor = true;
            this.enterU02C5Button.Click += new System.EventHandler(this.enterU02C5Button_Click);
            // 
            // enterU00ACButton
            // 
            this.enterU00ACButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterU00ACButton.Location = new System.Drawing.Point(598, 254);
            this.enterU00ACButton.Name = "enterU00ACButton";
            this.enterU00ACButton.Size = new System.Drawing.Size(70, 70);
            this.enterU00ACButton.TabIndex = 8;
            this.enterU00ACButton.Text = "¬";
            this.enterU00ACButton.UseVisualStyleBackColor = true;
            this.enterU00ACButton.Click += new System.EventHandler(this.enterU00ACButton_Click);
            // 
            // enterU2192Button
            // 
            this.enterU2192Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterU2192Button.Location = new System.Drawing.Point(512, 341);
            this.enterU2192Button.Name = "enterU2192Button";
            this.enterU2192Button.Size = new System.Drawing.Size(70, 70);
            this.enterU2192Button.TabIndex = 9;
            this.enterU2192Button.Text = "→";
            this.enterU2192Button.UseVisualStyleBackColor = true;
            this.enterU2192Button.Click += new System.EventHandler(this.enterU2192Button_Click);
            // 
            // sequenceValidationLabel
            // 
            this.sequenceValidationLabel.AutoSize = true;
            this.sequenceValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sequenceValidationLabel.Location = new System.Drawing.Point(262, 13);
            this.sequenceValidationLabel.Name = "sequenceValidationLabel";
            this.sequenceValidationLabel.Size = new System.Drawing.Size(232, 25);
            this.sequenceValidationLabel.TabIndex = 10;
            this.sequenceValidationLabel.Text = "sequenceValidationLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sequenceValidationLabel);
            this.Controls.Add(this.enterU2192Button);
            this.Controls.Add(this.enterU00ACButton);
            this.Controls.Add(this.enterU02C5Button);
            this.Controls.Add(this.enterU02C4Button);
            this.Controls.Add(this.enterU0370Button);
            this.Controls.Add(this.getResultButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputSequenceLabel);
            this.Controls.Add(this.enterSequenceTextBox);
            this.Name = "Form1";
            this.Text = "Sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterSequenceTextBox;
        private System.Windows.Forms.Label inputSequenceLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button getResultButton;
        private System.Windows.Forms.Button enterU0370Button;
        private System.Windows.Forms.Button enterU02C4Button;
        private System.Windows.Forms.Button enterU02C5Button;
        private System.Windows.Forms.Button enterU00ACButton;
        private System.Windows.Forms.Button enterU2192Button;
        private System.Windows.Forms.Label sequenceValidationLabel;
    }
}

