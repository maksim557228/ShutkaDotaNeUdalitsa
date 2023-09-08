namespace WinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 86);
            label1.TabIndex = 0;
            label1.Text = "Привет";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(607, 50);
            label2.TabIndex = 1;
            label2.Text = "Есля нажмёшь на эту кнапку 🔽";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(148, 185);
            button1.Name = "button1";
            button1.Size = new Size(422, 93);
            button1.TabIndex = 2;
            button1.Text = "нажми на меня";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 315);
            label3.Name = "label3";
            label3.Size = new Size(632, 40);
            label3.TabIndex = 3;
            label3.Text = "То у тебя удалится Дота 2 мобайл ледженс";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 391);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "СУПЕР УДАЛЯТАР ДОТА 2 МОБАЙЛ ЛЕДЖЕНС 1000-7 Я УМЕР ПРАСТИ ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}