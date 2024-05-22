namespace VAPW_predtermin_220524
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
            number1 = new Label();
            number2 = new Label();
            number3 = new Label();
            period_number1 = new NumericUpDown();
            period_number2 = new NumericUpDown();
            period_number3 = new NumericUpDown();
            num_of_players = new NumericUpDown();
            label4 = new Label();
            btn_start = new Button();
            list_of_players = new ListBox();
            ((System.ComponentModel.ISupportInitialize)period_number1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)period_number2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)period_number3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_of_players).BeginInit();
            SuspendLayout();
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number1.Location = new Point(72, 70);
            number1.Name = "number1";
            number1.Size = new Size(72, 30);
            number1.TabIndex = 0;
            number1.Text = "label1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number2.Location = new Point(239, 70);
            number2.Name = "number2";
            number2.Size = new Size(72, 30);
            number2.TabIndex = 1;
            number2.Text = "label2";
            // 
            // number3
            // 
            number3.AutoSize = true;
            number3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number3.Location = new Point(406, 70);
            number3.Name = "number3";
            number3.Size = new Size(72, 30);
            number3.TabIndex = 2;
            number3.Text = "label3";
            // 
            // period_number1
            // 
            period_number1.Location = new Point(38, 127);
            period_number1.Name = "period_number1";
            period_number1.Size = new Size(120, 23);
            period_number1.TabIndex = 3;
            // 
            // period_number2
            // 
            period_number2.Location = new Point(210, 127);
            period_number2.Name = "period_number2";
            period_number2.Size = new Size(120, 23);
            period_number2.TabIndex = 4;
            // 
            // period_number3
            // 
            period_number3.Location = new Point(388, 127);
            period_number3.Name = "period_number3";
            period_number3.Size = new Size(120, 23);
            period_number3.TabIndex = 5;
            // 
            // num_of_players
            // 
            num_of_players.Location = new Point(210, 208);
            num_of_players.Name = "num_of_players";
            num_of_players.Size = new Size(120, 23);
            num_of_players.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 214);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Počet hráčů:";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(388, 219);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 8;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            // 
            // list_of_players
            // 
            list_of_players.FormattingEnabled = true;
            list_of_players.ItemHeight = 15;
            list_of_players.Location = new Point(565, 63);
            list_of_players.Name = "list_of_players";
            list_of_players.Size = new Size(191, 304);
            list_of_players.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(list_of_players);
            Controls.Add(btn_start);
            Controls.Add(label4);
            Controls.Add(num_of_players);
            Controls.Add(period_number3);
            Controls.Add(period_number2);
            Controls.Add(period_number1);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)period_number1).EndInit();
            ((System.ComponentModel.ISupportInitialize)period_number2).EndInit();
            ((System.ComponentModel.ISupportInitialize)period_number3).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_of_players).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number1;
        private Label number2;
        private Label number3;
        private NumericUpDown period_number1;
        private NumericUpDown period_number2;
        private NumericUpDown period_number3;
        private NumericUpDown num_of_players;
        private Label label4;
        private Button btn_start;
        private ListBox list_of_players;
    }
}
