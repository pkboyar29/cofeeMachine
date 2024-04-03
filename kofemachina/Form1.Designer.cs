namespace kofemachina
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
            this.components = new System.ComponentModel.Container();
            kofemachina.Drink drink1 = new kofemachina.Drink();
            kofemachina.Drink drink2 = new kofemachina.Drink();
            kofemachina.Drink drink3 = new kofemachina.Drink();
            kofemachina.Drink drink4 = new kofemachina.Drink();
            kofemachina.Drink drink5 = new kofemachina.Drink();
            kofemachina.Drink drink6 = new kofemachina.Drink();
            kofemachina.Drink drink7 = new kofemachina.Drink();
            kofemachina.Drink drink8 = new kofemachina.Drink();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGetDrink = new System.Windows.Forms.Button();
            this.buttonGetChange = new System.Windows.Forms.Button();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPutMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelSugar = new System.Windows.Forms.Label();
            this.labelStrong = new System.Windows.Forms.Label();
            this.trackBarStrong = new System.Windows.Forms.TrackBar();
            this.trackBarSugar = new System.Windows.Forms.TrackBar();
            this.rub10 = new System.Windows.Forms.Button();
            this.rub50 = new System.Windows.Forms.Button();
            this.rub100 = new System.Windows.Forms.Button();
            this.rub200 = new System.Windows.Forms.Button();
            this.creamCheckBox = new System.Windows.Forms.CheckBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelChange = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDrinkReady = new System.Windows.Forms.Label();
            this.drinkControl1 = new kofemachina.DrinkControl();
            this.drinkControl2 = new kofemachina.DrinkControl();
            this.drinkControl3 = new kofemachina.DrinkControl();
            this.drinkControl4 = new kofemachina.DrinkControl();
            this.drinkControl5 = new kofemachina.DrinkControl();
            this.drinkControl6 = new kofemachina.DrinkControl();
            this.drinkControl7 = new kofemachina.DrinkControl();
            this.drinkControl8 = new kofemachina.DrinkControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSugar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetDrink
            // 
            this.buttonGetDrink.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetDrink.Location = new System.Drawing.Point(17, 621);
            this.buttonGetDrink.Name = "buttonGetDrink";
            this.buttonGetDrink.Size = new System.Drawing.Size(241, 54);
            this.buttonGetDrink.TabIndex = 6;
            this.buttonGetDrink.Text = "Забрать напиток";
            this.buttonGetDrink.UseVisualStyleBackColor = true;
            this.buttonGetDrink.Click += new System.EventHandler(this.buttonGetDrink_Click);
            // 
            // buttonGetChange
            // 
            this.buttonGetChange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetChange.Location = new System.Drawing.Point(459, 152);
            this.buttonGetChange.Name = "buttonGetChange";
            this.buttonGetChange.Size = new System.Drawing.Size(165, 44);
            this.buttonGetChange.TabIndex = 7;
            this.buttonGetChange.Text = "Забрать сдачу";
            this.buttonGetChange.UseVisualStyleBackColor = true;
            this.buttonGetChange.Click += new System.EventHandler(this.GetChangeClick);
            // 
            // buttonCook
            // 
            this.buttonCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCook.Location = new System.Drawing.Point(17, 461);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(127, 44);
            this.buttonCook.TabIndex = 8;
            this.buttonCook.Text = "Приготовить";
            this.buttonCook.UseVisualStyleBackColor = true;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(150, 461);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 44);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите напиток";
            // 
            // labelPutMoney
            // 
            this.labelPutMoney.AutoSize = true;
            this.labelPutMoney.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPutMoney.Location = new System.Drawing.Point(458, 9);
            this.labelPutMoney.Name = "labelPutMoney";
            this.labelPutMoney.Size = new System.Drawing.Size(214, 32);
            this.labelPutMoney.TabIndex = 11;
            this.labelPutMoney.Text = "Положите деньги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Опции";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(458, 117);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(115, 32);
            this.labelBalance.TabIndex = 13;
            this.labelBalance.Text = "Баланс: 0";
            // 
            // labelSugar
            // 
            this.labelSugar.AutoSize = true;
            this.labelSugar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSugar.Location = new System.Drawing.Point(106, 365);
            this.labelSugar.Name = "labelSugar";
            this.labelSugar.Size = new System.Drawing.Size(52, 21);
            this.labelSugar.TabIndex = 22;
            this.labelSugar.Text = "Сахар";
            // 
            // labelStrong
            // 
            this.labelStrong.AutoSize = true;
            this.labelStrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStrong.Location = new System.Drawing.Point(16, 365);
            this.labelStrong.Name = "labelStrong";
            this.labelStrong.Size = new System.Drawing.Size(84, 21);
            this.labelStrong.TabIndex = 23;
            this.labelStrong.Text = "Крепкость";
            // 
            // trackBarStrong
            // 
            this.trackBarStrong.Location = new System.Drawing.Point(16, 389);
            this.trackBarStrong.Maximum = 5;
            this.trackBarStrong.Name = "trackBarStrong";
            this.trackBarStrong.Size = new System.Drawing.Size(78, 45);
            this.trackBarStrong.TabIndex = 24;
            // 
            // trackBarSugar
            // 
            this.trackBarSugar.Location = new System.Drawing.Point(100, 389);
            this.trackBarSugar.Maximum = 5;
            this.trackBarSugar.Name = "trackBarSugar";
            this.trackBarSugar.Size = new System.Drawing.Size(78, 45);
            this.trackBarSugar.TabIndex = 25;
            // 
            // rub10
            // 
            this.rub10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rub10.Location = new System.Drawing.Point(458, 48);
            this.rub10.Name = "rub10";
            this.rub10.Size = new System.Drawing.Size(85, 30);
            this.rub10.TabIndex = 26;
            this.rub10.Tag = "10";
            this.rub10.Text = "10";
            this.rub10.UseVisualStyleBackColor = true;
            this.rub10.Click += new System.EventHandler(this.billClick);
            // 
            // rub50
            // 
            this.rub50.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rub50.Location = new System.Drawing.Point(458, 84);
            this.rub50.Name = "rub50";
            this.rub50.Size = new System.Drawing.Size(85, 30);
            this.rub50.TabIndex = 28;
            this.rub50.Tag = "50";
            this.rub50.Text = "50";
            this.rub50.UseVisualStyleBackColor = true;
            this.rub50.Click += new System.EventHandler(this.billClick);
            // 
            // rub100
            // 
            this.rub100.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rub100.Location = new System.Drawing.Point(549, 48);
            this.rub100.Name = "rub100";
            this.rub100.Size = new System.Drawing.Size(85, 30);
            this.rub100.TabIndex = 29;
            this.rub100.Tag = "100";
            this.rub100.Text = "100";
            this.rub100.UseVisualStyleBackColor = true;
            this.rub100.Click += new System.EventHandler(this.billClick);
            // 
            // rub200
            // 
            this.rub200.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rub200.Location = new System.Drawing.Point(549, 84);
            this.rub200.Name = "rub200";
            this.rub200.Size = new System.Drawing.Size(85, 30);
            this.rub200.TabIndex = 30;
            this.rub200.Tag = "200";
            this.rub200.Text = "200";
            this.rub200.UseVisualStyleBackColor = true;
            this.rub200.Click += new System.EventHandler(this.billClick);
            // 
            // creamCheckBox
            // 
            this.creamCheckBox.AutoSize = true;
            this.creamCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creamCheckBox.Location = new System.Drawing.Point(17, 430);
            this.creamCheckBox.Name = "creamCheckBox";
            this.creamCheckBox.Size = new System.Drawing.Size(81, 25);
            this.creamCheckBox.TabIndex = 31;
            this.creamCheckBox.Text = "Сливки";
            this.creamCheckBox.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.milkCheckBox.Location = new System.Drawing.Point(106, 430);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(86, 25);
            this.milkCheckBox.TabIndex = 32;
            this.milkCheckBox.Text = "Молоко";
            this.milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChange.Location = new System.Drawing.Point(459, 205);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(0, 32);
            this.labelChange.TabIndex = 33;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 520);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 36);
            this.progressBar1.TabIndex = 42;
            this.progressBar1.Visible = false;
            // 
            // labelDrinkReady
            // 
            this.labelDrinkReady.AutoSize = true;
            this.labelDrinkReady.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDrinkReady.Location = new System.Drawing.Point(17, 571);
            this.labelDrinkReady.Name = "labelDrinkReady";
            this.labelDrinkReady.Size = new System.Drawing.Size(0, 32);
            this.labelDrinkReady.TabIndex = 43;
            // 
            // drinkControl1
            // 
            this.drinkControl1.BackColor = System.Drawing.Color.White;
            this.drinkControl1.Dr = drink1;
            this.drinkControl1.Location = new System.Drawing.Point(12, 48);
            this.drinkControl1.Name = "drinkControl1";
            this.drinkControl1.Size = new System.Drawing.Size(132, 63);
            this.drinkControl1.TabIndex = 44;
            this.drinkControl1.Tag = "1";
            this.drinkControl1.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl2
            // 
            this.drinkControl2.BackColor = System.Drawing.Color.White;
            this.drinkControl2.Dr = drink2;
            this.drinkControl2.Location = new System.Drawing.Point(150, 48);
            this.drinkControl2.Name = "drinkControl2";
            this.drinkControl2.Size = new System.Drawing.Size(132, 63);
            this.drinkControl2.TabIndex = 45;
            this.drinkControl2.Tag = "1";
            this.drinkControl2.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl3
            // 
            this.drinkControl3.BackColor = System.Drawing.Color.White;
            this.drinkControl3.Dr = drink3;
            this.drinkControl3.Location = new System.Drawing.Point(12, 117);
            this.drinkControl3.Name = "drinkControl3";
            this.drinkControl3.Size = new System.Drawing.Size(132, 63);
            this.drinkControl3.TabIndex = 46;
            this.drinkControl3.Tag = "1";
            this.drinkControl3.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl4
            // 
            this.drinkControl4.BackColor = System.Drawing.Color.White;
            this.drinkControl4.Dr = drink4;
            this.drinkControl4.Location = new System.Drawing.Point(150, 117);
            this.drinkControl4.Name = "drinkControl4";
            this.drinkControl4.Size = new System.Drawing.Size(132, 63);
            this.drinkControl4.TabIndex = 47;
            this.drinkControl4.Tag = "1";
            this.drinkControl4.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl5
            // 
            this.drinkControl5.BackColor = System.Drawing.Color.White;
            this.drinkControl5.Dr = drink5;
            this.drinkControl5.Location = new System.Drawing.Point(12, 186);
            this.drinkControl5.Name = "drinkControl5";
            this.drinkControl5.Size = new System.Drawing.Size(132, 63);
            this.drinkControl5.TabIndex = 48;
            this.drinkControl5.Tag = "1";
            this.drinkControl5.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl6
            // 
            this.drinkControl6.BackColor = System.Drawing.Color.White;
            this.drinkControl6.Dr = drink6;
            this.drinkControl6.Location = new System.Drawing.Point(150, 186);
            this.drinkControl6.Name = "drinkControl6";
            this.drinkControl6.Size = new System.Drawing.Size(132, 63);
            this.drinkControl6.TabIndex = 49;
            this.drinkControl6.Tag = "1";
            this.drinkControl6.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl7
            // 
            this.drinkControl7.BackColor = System.Drawing.Color.White;
            this.drinkControl7.Dr = drink7;
            this.drinkControl7.Location = new System.Drawing.Point(12, 255);
            this.drinkControl7.Name = "drinkControl7";
            this.drinkControl7.Size = new System.Drawing.Size(132, 63);
            this.drinkControl7.TabIndex = 50;
            this.drinkControl7.Tag = "1";
            this.drinkControl7.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // drinkControl8
            // 
            this.drinkControl8.BackColor = System.Drawing.Color.White;
            this.drinkControl8.Dr = drink8;
            this.drinkControl8.Location = new System.Drawing.Point(150, 255);
            this.drinkControl8.Name = "drinkControl8";
            this.drinkControl8.Size = new System.Drawing.Size(132, 63);
            this.drinkControl8.TabIndex = 51;
            this.drinkControl8.Tag = "1";
            this.drinkControl8.Click += new System.EventHandler(this.drinkControlClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.drinkControl8);
            this.Controls.Add(this.drinkControl7);
            this.Controls.Add(this.drinkControl6);
            this.Controls.Add(this.drinkControl5);
            this.Controls.Add(this.drinkControl4);
            this.Controls.Add(this.drinkControl3);
            this.Controls.Add(this.drinkControl2);
            this.Controls.Add(this.drinkControl1);
            this.Controls.Add(this.labelDrinkReady);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.milkCheckBox);
            this.Controls.Add(this.creamCheckBox);
            this.Controls.Add(this.rub200);
            this.Controls.Add(this.rub100);
            this.Controls.Add(this.rub50);
            this.Controls.Add(this.rub10);
            this.Controls.Add(this.trackBarSugar);
            this.Controls.Add(this.trackBarStrong);
            this.Controls.Add(this.labelStrong);
            this.Controls.Add(this.labelSugar);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPutMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCook);
            this.Controls.Add(this.buttonGetChange);
            this.Controls.Add(this.buttonGetDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кофемашина";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetDrink;
        private System.Windows.Forms.Button buttonGetChange;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPutMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelSugar;
        private System.Windows.Forms.Label labelStrong;
        private System.Windows.Forms.TrackBar trackBarStrong;
        private System.Windows.Forms.TrackBar trackBarSugar;
        private System.Windows.Forms.Button rub10;
        private System.Windows.Forms.Button rub50;
        private System.Windows.Forms.Button rub100;
        private System.Windows.Forms.Button rub200;
        private System.Windows.Forms.CheckBox creamCheckBox;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDrinkReady;
        private DrinkControl drinkControl1;
        private DrinkControl drinkControl2;
        private DrinkControl drinkControl3;
        private DrinkControl drinkControl4;
        private DrinkControl drinkControl5;
        private DrinkControl drinkControl6;
        private DrinkControl drinkControl7;
        private DrinkControl drinkControl8;
    }
}
