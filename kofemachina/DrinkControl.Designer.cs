namespace kofemachina
{
    partial class DrinkControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(3, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 17);
            this.labelName.TabIndex = 0;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCost.Location = new System.Drawing.Point(3, 33);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(0, 25);
            this.labelCost.TabIndex = 1;
            // 
            // DrinkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Name = "DrinkControl";
            this.Size = new System.Drawing.Size(150, 73);
            this.Load += new System.EventHandler(this.DrinkControl_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrinkControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrinkControl_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
    }
}
