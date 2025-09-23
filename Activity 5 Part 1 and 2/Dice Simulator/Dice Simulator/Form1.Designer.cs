namespace Dice_Simulator
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
            btnRollDice = new Button();
            pbDie1 = new PictureBox();
            pbDie2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDie1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDie2).BeginInit();
            SuspendLayout();
            // 
            // btnRollDice
            // 
            btnRollDice.BackColor = Color.LightCoral;
            btnRollDice.Font = new Font("Elephant", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRollDice.Location = new Point(315, 360);
            btnRollDice.Margin = new Padding(3, 4, 3, 4);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(144, 65);
            btnRollDice.TabIndex = 0;
            btnRollDice.Text = "Roll Dice";
            btnRollDice.UseVisualStyleBackColor = false;
            btnRollDice.Click += BtnRollDice_ClickEvent;
            // 
            // pbDie1
            // 
            pbDie1.Image = Properties.Resources.Die1;
            pbDie1.Location = new Point(166, 125);
            pbDie1.Name = "pbDie1";
            pbDie1.Size = new Size(151, 142);
            pbDie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDie1.TabIndex = 1;
            pbDie1.TabStop = false;
            // 
            // pbDie2
            // 
            pbDie2.Image = Properties.Resources.Die2;
            pbDie2.Location = new Point(447, 125);
            pbDie2.Name = "pbDie2";
            pbDie2.Size = new Size(151, 142);
            pbDie2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDie2.TabIndex = 2;
            pbDie2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 26);
            label1.Name = "label1";
            label1.Size = new Size(302, 43);
            label1.TabIndex = 3;
            label1.Text = "Dice Roll Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(765, 600);
            Controls.Add(label1);
            Controls.Add(pbDie2);
            Controls.Add(pbDie1);
            Controls.Add(btnRollDice);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)pbDie1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDie2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRollDice;
        private PictureBox pbDie1;
        private PictureBox pbDie2;
        private Label label1;
    }
}
