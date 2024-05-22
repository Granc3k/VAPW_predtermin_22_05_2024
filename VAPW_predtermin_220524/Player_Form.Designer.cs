namespace VAPW_predtermin_220524
{
    partial class Player_Form
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
            btn_stop = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            num_on_stop = new Label();
            btn_close = new Button();
            SuspendLayout();
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(104, 105);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(75, 23);
            btn_stop.TabIndex = 0;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Jméno hráče:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // num_on_stop
            // 
            num_on_stop.AutoSize = true;
            num_on_stop.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num_on_stop.Location = new Point(104, 159);
            num_on_stop.Name = "num_on_stop";
            num_on_stop.Size = new Size(0, 30);
            num_on_stop.TabIndex = 3;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(104, 252);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 4;
            btn_close.Text = "Zavřít";
            btn_close.UseVisualStyleBackColor = true;
            // 
            // Player_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 287);
            Controls.Add(btn_close);
            Controls.Add(num_on_stop);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_stop);
            Name = "Player_Form";
            Text = "Player_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_stop;
        private Label label1;
        private TextBox textBox1;
        private Label num_on_stop;
        private Button btn_close;
    }
}