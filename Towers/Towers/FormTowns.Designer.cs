namespace Towers
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTowns = new System.Windows.Forms.TextBox();
            this.buttonAddTown = new System.Windows.Forms.Button();
            this.listBoxTowns = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTowns
            // 
            this.textBoxTowns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTowns.Location = new System.Drawing.Point(95, 125);
            this.textBoxTowns.Name = "textBoxTowns";
            this.textBoxTowns.Size = new System.Drawing.Size(211, 31);
            this.textBoxTowns.TabIndex = 0;
            // 
            // buttonAddTown
            // 
            this.buttonAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTown.Location = new System.Drawing.Point(95, 197);
            this.buttonAddTown.Name = "buttonAddTown";
            this.buttonAddTown.Size = new System.Drawing.Size(211, 44);
            this.buttonAddTown.TabIndex = 1;
            this.buttonAddTown.Text = "Добавить город";
            this.buttonAddTown.UseVisualStyleBackColor = true;
            this.buttonAddTown.Click += new System.EventHandler(this.buttonAddTown_Click);
            // 
            // listBoxTowns
            // 
            this.listBoxTowns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTowns.FormattingEnabled = true;
            this.listBoxTowns.ItemHeight = 25;
            this.listBoxTowns.Location = new System.Drawing.Point(511, 125);
            this.listBoxTowns.Name = "listBoxTowns";
            this.listBoxTowns.Size = new System.Drawing.Size(186, 204);
            this.listBoxTowns.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTowns);
            this.Controls.Add(this.buttonAddTown);
            this.Controls.Add(this.textBoxTowns);
            this.Name = "Form1";
            this.Text = "Играем в города";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTowns;
        private System.Windows.Forms.Button buttonAddTown;
        private System.Windows.Forms.ListBox listBoxTowns;
    }
}

